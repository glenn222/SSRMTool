using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Text;
using SSRMTool;


namespace SSRMToolDB
{
    class DBManager
    {
        private static DBManager dbManager;
        private RedisClient redis;
        private List<String> staircaseKeys;
        private List<Staircase> staircases;

        // TODO:: Check for adding or modifying 
        // TODO:: Modify date time for existing staircases (Date Created)
        // TODO:: Verify getting all staircases 
        // TODO:: Write and Query
        // TODO:: Integration tests...

        private DBManager()
        {
            redis = new RedisClient();
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                staircaseKeys = redisUsers.GetAllKeys();
                staircases = redisUsers.GetValues(staircaseKeys.ToList());
            }
        }

        private void UpdateLists()
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                staircaseKeys = redisUsers.GetAllKeys();
                IList<Staircase> staircasesTest = redisUsers.GetAll();
            }
        }

        // Implement Singleton for this class
        public static DBManager GetInstance()
        {
            if (dbManager == null)
            {
                dbManager = new DBManager();
            }
            return dbManager;
        }

        public List<String> StaircaseKeys
        {
            get { return staircaseKeys; }
        }

        public List<Staircase> Staircases
        {
            get { return staircases; }
        }

        public void ModifyStaircaseInDB(Staircase obj)
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                redisUsers.GetAndSetValue(obj.StaircaseName,obj);
            }
            this.UpdateLists();
        }

        public void DeleteStaircaseFromDB(Staircase obj)
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                redisUsers.RemoveEntry(obj.StaircaseName);
            }
            this.UpdateLists();
        }

        public void AddStaircaseInDB(Staircase obj)
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                redisUsers.GetAndSetValue(obj.StaircaseName, obj);
            }
            this.UpdateLists();
        }

       
    }
}
