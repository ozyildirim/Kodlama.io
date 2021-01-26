using Gun5Odev5.Abstract;

namespace Gun5Odev5.Entities
{
    class Sales
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int CampaignDiscount { get; set; }
        public int TotalCost { get; set; } //Total cost = Game Cost - Campaign Discount

    }
}
