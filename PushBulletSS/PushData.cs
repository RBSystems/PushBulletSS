﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace PushBulletSS {
    public class PushData {
        public string body, title, type;
        public double modified;
        public PushData(string title, string body, string type) {
            this.title = title; this.body = body; this.type = type;
        }
    }
}