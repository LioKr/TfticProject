using System;

namespace TfticProject_TerryPratchett.Api.Models.Client
{
    public class Saga
    {
        public int SagaId { get; set; }
        public string SagaName { get; set; }

		public Saga(string sagaName)
		{
			SagaName = sagaName;
		}

		public Saga(int id, string sagaName)
		: this(sagaName)
		{
			SagaId = id;
		}
	}
}
