/*
 * $Id: writegwy.c 181 2015-04-12 20:47:10Z yeti-dn $
 *
 * This example shows how to write a simple Gwyddion GWY file "test.gwy"
 * containing one image with a line selection and one graph with a couple of
 * curves.
 *
 * I, the copyright holder of this work, release this work into the public
 * domain.  This applies worldwide.  In some countries this may not be legally
 * possible; if so: I grant anyone the right to use this work for any purpose,
 * without any conditions, unless such conditions are required by law.
 */
#include <stdlib.h>
#include <math.h>
#include <errno.h>
#include <string.h>
#include "gwyfile.h"
#include "GwyddionLibraryAdaptee.h"

/* rand() is not good but it exists even in Win32 and suffices here. */
#define rng() (rand()/(double)RAND_MAX - 0.5)

double* CreateArray(int length) {
	double *new_array = (double*)malloc(length * sizeof(double));
	return new_array;
}
bool DestroyArray(double * used_array) {
	free(used_array);
	return true;
}
double* ReadGWYChannelData(char* path, int id, int *resX, int *resY) {
	GwyfileObject *gwyf;
	GwyfileError *error = NULL;
	unsigned int i;
	char* new_path = "d19_tip11.gwy";
	gwyf = gwyfile_read_file(new_path, &error);
	if (!gwyf) { return NULL; }
	char key[32];
	int32_t xres, yres;
	double xreal, yreal;
	char *xyunit = NULL, *zunit = NULL;
	GwyfileItem *item, *auxitem;
	GwyfileObject *object;
	double *channelData,*channelDataCopy;
	/* Examine the main data field object. */
	snprintf(key, sizeof(key), "/%d/data", id);
	item = gwyfile_object_get(gwyf, key);
	object = gwyfile_item_get_object(item);
	gwyfile_object_datafield_get(object, &error,
		"xres", &xres, "yres", &yres,
		"xreal", &xreal, "yreal", &yreal,
		"si_unit_xy", &xyunit,
		"si_unit_z", &zunit,
		NULL);
	channelData = CreateArray(xres*yres);
	gwyfile_object_datafield_get(object, &error,
		"data", &channelData,
		NULL);
	channelDataCopy = CreateArray(xres*yres);
	for (int i = 0;i < xres*yres;i++) {
		channelDataCopy[i] = channelData[i];
	}
	*resX = xres;
	*resY = yres;
	gwyfile_object_free(gwyf);
	return channelDataCopy;
}
int* ReadGWYChannelNames(char *path, unsigned int* n) {
	GwyfileObject *gwyf;
	GwyfileError *error = NULL;
	unsigned int i;
	int* ids;
	gwyf = gwyfile_read_file("d19_tip11.gwy", &error);
	if (!gwyf) {
		ids = n;
		gwyfile_object_free(gwyf);
		return ids;
	}
	else {
		ids = gwyfile_object_container_enumerate_channels(gwyf,n);
		gwyfile_object_free(gwyf);
		return ids;
	}
}
bool
WriteGWY(double *imagedata,unsigned int xres,unsigned int yres)
{
	GwyfileObject *gwyf, *gwyf2, *datafield;
	GwyfileError *error = NULL;
	datafield = gwyfile_object_new_datafield(xres, yres, 1.6e-9, 1.6e-9,
		"data", imagedata,
		"si_unit_xy", "m",
		"si_unit_z", "",
		NULL);

	gwyf = gwyfile_object_new("GwyContainer",
		gwyfile_item_new_object("/0/data", datafield),
		NULL);
	/* Write the top-level GwyContainer to a file. */
	if (!gwyfile_write_file(gwyf, "d19_R.gwy", &error)) {
		//fprintf(stderr, "Cannot write test.gwy: %s\n", error->message);
		gwyfile_error_clear(&error);
		exit(EXIT_FAILURE);
	}
	gwyfile_object_free(gwyf);
	return true;
}
bool
WriteGWYChannel(char* path, double *imagedata, unsigned int xres, unsigned int yres) {
	GwyfileObject *gwyf,*gwyftemp,*datafield;
	char key[32];
	GwyfileError *error = NULL;
	unsigned int i,n;
	int* ids;
	gwyf = gwyfile_read_file("d19_tip11.gwy", &error);
	if (!gwyf) {
		gwyfile_object_free(gwyf);
		return false;
	}
	else {
		ids = gwyfile_object_container_enumerate_channels(gwyf, &n);
		datafield = gwyfile_object_new_datafield(xres, yres, 1.6e-9, 1.6e-9,
			"data", imagedata,
			"si_unit_xy", "m",
			"si_unit_z", "",
			NULL);
		snprintf(key, sizeof(key), "/%d/data", n);
		gwyftemp = gwyfile_object_new("GwyContainer",
			gwyfile_item_new_object(key, datafield),
			NULL);
		bool added = (gwyfile_object_add(gwyf, gwyfile_object_get(gwyftemp, key)));
		bool saved = gwyfile_write_file(gwyf, "d19_R.gwy", &error);
		gwyfile_object_free(gwyf);
		return added&&saved;
	}
}