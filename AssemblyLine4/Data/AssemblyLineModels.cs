using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssemblyLine4.Data
{
    public class Operation
    {
        [Key]
        public int OperationID { get; set; }
        [Required (ErrorMessage ="Please enter a operation name")]
        [StringLength(50, ErrorMessage ="Please enter a operation name with less than 50 characters")]
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }

        public byte[] ImageData { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="Please select a Device")]
        [ForeignKey("Device")]
        public int DeviceID { get; set; }
        public Device Device { get; set; }

    }
    public class Device
    {
        [Key]
        public int DeviceID { get; set; }
        [Required(ErrorMessage ="Please add a Valid Device Name")]
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
    }
    public enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}
