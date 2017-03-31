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

        public DBManager GetInstance()
        {
            if (this == null)
            {
                DBManager doc = new DBManager();
                return doc;
            }
            else
                return this;
        }

        private List<String> StaircaseKeys
        {
            get { return staircaseKeys; }
        }

        private List<Staircase> Staircases
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
        }
        public void DeleteStaircaseFromDB(Staircase obj)
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                redisUsers.RemoveEntry(obj.StaircaseName);
            }
        }

        public void AddStaircaseInDB(Staircase obj)
        {
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                redisUsers.GetAndSetValue(obj.StaircaseName, obj);
            }

        }

       
    }
}
