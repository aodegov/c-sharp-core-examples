using System;

namespace Strings.StringSamples
{
    public class StringOps
    {
        public string StringFormatOps()
        {
            var deviceId = "A003466";
            var link = "";
            var result = string.Format(link, deviceId);
            return result;
        }
    }
}
