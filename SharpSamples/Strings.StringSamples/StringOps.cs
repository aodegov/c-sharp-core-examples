using System;

namespace Strings.StringSamples
{
    public class StringOps
    {
        public string StringFormatOps()
        {
            var deviceId = "A003466";
            var link = "https://beeapi.hapbee.com/v1/mobileapp/MobileCustomer/Customer.GetDeviceDetailsByDeviceId(deviceId='{0}')";
            var result = string.Format(link, deviceId);
            return result;
        }
    }
}
