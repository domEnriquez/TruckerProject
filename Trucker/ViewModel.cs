using System;
using System.Globalization;

namespace Trucker
{
    public abstract class ViewModel
    {
        protected void validateIfHasValue(string fieldName, string input)
        {
            if (input == string.Empty)
                throw new EmptyArgument(fieldName + " is required");
        }

        protected void validateDateFormat(string value)
        {
            if (!dateFollowsFormat(Convert.ToString(value), "MM/dd/yyyy"))
                throw new InvalidDateFormat("Wrong date format");
        }

        protected bool dateFollowsFormat(string date, string format)
        {
            DateTime dateTime;

            return DateTime.TryParseExact(
                date,
                format,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateTime);
        }

        protected void validateIfNumbersOnly(string fieldName, string input)
        {
            double num;

            if (!Double.TryParse(input, out num))
                throw new InvalidArgumentFormat(fieldName + " should be numbers only");
        }

        public class EmptyArgument : ApplicationException
        {
            public EmptyArgument()
            {

            }

            public EmptyArgument(string message)
                : base(message)
            {

            }
        }

        public class InvalidArgumentFormat : ApplicationException
        {
            public InvalidArgumentFormat()
            {

            }

            public InvalidArgumentFormat(string message)
                : base(message)
            {

            }
        }

        public class InvalidDateFormat : ApplicationException
        {
            public InvalidDateFormat()
            {

            }

            public InvalidDateFormat(string message)
                : base(message)
            {

            }
        }
    }
}
