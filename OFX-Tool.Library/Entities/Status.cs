﻿using RFD.OFXTool.Library.Attributes;
using RFD.OFXTool.Library.Enums;

namespace RFD.OFXTool.Library.Entities
{
    [Element("STATUS")]
    public class Status
    {
        //
        // Résumé :
        //     Gets or sets the error code.
        [Element("CODE")]
        public string? Code { get; set; }
        //
        // Résumé :
        //     Gets or sets the severity of the error.
        [Element("SEVERITY")]
        public SeverityEnum? Severity { get; set; }
        //
        // Résumé :
        //     Gets or sets the textual explanation from the FI.
        [Element("MESSAGE")]
        public string? Message { get; set; }


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
                Status e = (Status)obj;
                return Entity.PropertyEquality(e.Code, Code) &&
                    Entity.PropertyEquality(e.Severity, Severity) &&
                    Entity.PropertyEquality(e.Message, Message);
            }
        }

        //Serves as the default hash function
        public override int GetHashCode() => new { Code, Severity, Message }.GetHashCode();
    }
}