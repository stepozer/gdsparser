using System;

namespace InfrastuctureLayer.Gds.Sirena
{
    public class Client
    {
        private Logger _logger;

        public Client(Logger logger)
        {
            _logger = logger;
        }
        
        public string Request(string requestName)
        {
            _logger.Info($"request: {requestName}");
            if (requestName == "Trips")
            {
                var response = @"
                    <Trips>
                      <Trip>
                        <Supplier>SU</Supplier>
                        <Fligth>10</Fligth>
                      </Trip>
                      <Trip>
                        <Supplier>S7</Supplier>
                        <Fligth>11</Fligth>
                      </Trip>
                      <Trip>
                        <Supplier>N4</Supplier>
                        <Fligth>15</Fligth>
                      </Trip>
                      <Trip>
                        <Supplier>XX</Supplier>
                        <Fligth>20</Fligth>
                      </Trip>
                    </Trips>
                ";
                _logger.Info($"response: {response}");
                return response;
            }

            throw new Exception($"Unknown request {requestName}");
        }
    }
}