using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_UI
{
    class ForecastTable : DataTable
    {
        // An instance of a DataTable with some default columns.  Expressions help quickly calculate E
        public ForecastTable()
        {
            this.Columns.Add("Instance", typeof(Int32));    //The position in which this value occurred in the time-series
            this.Columns.Add("Value", typeof(Decimal));     //The value which actually occurred
            this.Columns.Add("Forecast", typeof(Decimal));  //The forecasted value for this instance
            //this.Columns.Add("Holdout", typeof(Boolean));   //Identifies a holdout actual value row, for testing after err is calculated

            //E(t) = D(t) - F(t)
            this.Columns.Add("Error", typeof(Decimal), "Forecast-Value");
            //Absolute Error = |E(t)|
            this.Columns.Add("AbsoluteError", typeof(Decimal), "IIF(Error>=0, Error, Error * -1)");
            //Percent Error = E(t) / D(t)
            this.Columns.Add("PercentError", typeof(Decimal), "IIF(Value<>0, Error / Value, Null)");
            //Absolute Percent Error = |E(t)| / D(t)
            this.Columns.Add("AbsolutePercentError", typeof(Decimal), "IIF(Value <> 0, AbsoluteError / Value, Null)");
        }
    }
}
