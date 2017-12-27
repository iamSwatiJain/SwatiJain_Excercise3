using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwatiJain_Excercise3
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired an error!";
    }

    public class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numeric only field. This fired an error!";
    }

    public class NegativeInputError : UserError
    {
        public override string UEMessage() => "You tried to use a negative input in a positive only field. This fired an error!";
    }

    public class DateInputError : UserError
    {
        public override string UEMessage() => "You tried to use a date input in a text only field. This fired an error!";
    }

    public class TimeInputError : UserError
    {
        public override string UEMessage() => "You tried to use a time input in a text only field. This fired an error!";
    }
}
