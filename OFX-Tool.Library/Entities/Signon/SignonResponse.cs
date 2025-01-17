﻿using RFD.OFXTool.Library.Attributes;
using RFD.OFXTool.Library.Enums;

namespace RFD.OFXTool.Library.Entities.Signon
{
    [Element("SONRS")]
    public class SignonResponse
    {
        public Status? Status { get; set; }
        [Element("DTSERVER")]
        public string? ServerDate { get; set; }
        [Element("LANGUAGE")]
        public LanguageEnum? Language { get; set; }

        // Determines whether the specified object is equal to the current object.
        public override bool Equals(object? obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                SignonResponse e = (SignonResponse)obj;
                return Entity.PropertyEquality(e.Status, Status) &&
                    Entity.PropertyEquality(e.ServerDate, ServerDate) &&
                    Entity.PropertyEquality(e.Language, Language);
            }
        }

        //Serves as the default hash function
        public override int GetHashCode() => new { Status, ServerDate, Language }.GetHashCode();
    }
}