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
    class DocumentManager
    {   
        private RedisClient redis;
        private List<String> staircaseKeys;
        private List<Staircase> staircases;

        private DocumentManager()
        {
            redis = new RedisClient();
            using (redis)
            {
                IRedisTypedClient<Staircase> redisUsers = redis.As<Staircase>();
                staircaseKeys = redisUsers.GetAllKeys();
                staircases = redisUsers.GetAll().ToList();
            }
        }

        public DocumentManager GetInstance()
        {
            if (this == null)
            {
                DocumentManager doc = new DocumentManager();
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
