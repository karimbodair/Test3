﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL { 

        public class Episode
        {
            //Ordningen på noden bestämmer hur den kommer visas i XML-filen.
            public string Title { get; set; } //Här har vi skapat Title till avsnitten, detta är en node.
            public string Url { get; set; } //Här har vi skapat url-noden till avsnitten som håller ljudfilen.
            public string Description { get; set; }
        }
    }



