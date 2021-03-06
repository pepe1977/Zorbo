﻿using Jurassic.Library;
using Zorbo.Core;
using JScript = Javascript.Script;

namespace Javascript.Objects
{
    public class Password : ScriptObject
    {
        readonly IPassword password;

        [JSProperty(Name = "level", IsEnumerable = true)]
        public int Level {
            get { return (int)password.Level; }
            set {
                value = (value < 0) ? 0 : value;
                value = (value > (int)AdminLevel.Host) ? (int)AdminLevel.Host : value;

                password.Level = (AdminLevel)value;
            }
        }

        [JSProperty(Name = "password", IsEnumerable = true)]
        public string Sha1Text {
            get { return password.Sha1Text; }
        }

        public Password(JScript script, IPassword password)
            : base(script.Engine) {

            this.password = password;
            this.PopulateFunctions();
        }
    }
}
