﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Watchlist_app_win8.DataFetchers;

namespace Watchlist_app_win8.Logic
{
    class Json
    {
        public static Movies deserializeJson(string jsonString)
        {
            Movies movie = JsonConvert.DeserializeObject<Movies>(jsonString);
            return movie;
        }

        public static Movie deserializeJsonMetaData(string jsonString)
        {
            Movie movie = JsonConvert.DeserializeObject<Movie>(jsonString);
            return movie;
        }

        public static User Serialization_User(string jsonString)
        {
            jsonString = jsonString.Substring(1, jsonString.Length - 2);
            User CurrentUser = JsonConvert.DeserializeObject<User>(jsonString);
            CurrentUser.jsonString = jsonString;
            return CurrentUser;
        }

    }
}
