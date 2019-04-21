using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsDAL.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public long PricePerUnit { get; set; }
        public int MeasurementUnitName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
public enum MeasurementUnit
{
    feet = 1,
    inch = 2,
    kg = 3,
    litre = 4,
    pounds = 5,
}