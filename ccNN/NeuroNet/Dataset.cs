namespace ccNN
{
	public class DataSet
	{
		#region -- Properties --
		public double[] Values { get; set; }
		public double[] Targets { get; set; }
		#endregion

		#region -- Constructor --
		public DataSet(double[] values, double[] targets)
		{
			Values = values;
			Targets = targets;
		}
        #endregion

        public static DataSet[] test32Data = {
        new DataSet(new double[] { 0.0, 0.0, 0.0 }, new double[] { 0.0, 0.0 }),
        new DataSet(new double[] { 1.0, 0.0, 0.0 }, new double[] { 1.0, 0.0 }),
        new DataSet(new double[] { 1.0, 1.0, 0.0 }, new double[] { 1.0, 0.0 }),
        new DataSet(new double[] { 1.0, 1.0, 1.0 }, new double[] { 1.0, 1.0 }),
        new DataSet(new double[] { 1.0, 0.0, 1.0 }, new double[] { 0.0, 0.0 }),
        new DataSet(new double[] { 0.0, 1.0, 0.0 }, new double[] { 0.0, 0.0 }),
        new DataSet(new double[] { 0.0, 1.0, 1.0 }, new double[] { 0.0, 1.0 }),
        new DataSet(new double[] { 0.0, 0.0, 1.0 }, new double[] { 0.0, 1.0 })};



	}
}