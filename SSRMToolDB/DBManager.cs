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

        private DBManager()
        {
            redis = new RedisClient();
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                staircaseKeys = redisUsers.GetAllKeys();
                staircases = redisUsers.GetAll().ToList();
            }
        }

        private void UpdateLists()
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                staircaseKeys = redisUsers.GetAllKeys();
                staircases = redisUsers.GetAll().ToList();
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
