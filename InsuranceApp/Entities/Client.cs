namespace Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactInfo { get; set; }
        public string Policy { get; set; } 

  
        public Client() { }

       
        public Client(int clientId, string clientName, string contactInfo, string policy)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            Policy = policy;
        }

   
        public override string ToString()
        {
            return $"Client [ClientId={ClientId}, ClientName={ClientName}, ContactInfo={ContactInfo}, Policy={Policy}]";
        }
    }
}
