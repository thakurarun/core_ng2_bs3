namespace POC_CORE_Angular2.WebModel.DTO
{
    public class MovieDTO
    {
        public int id { get; set; }
        public string url { get; set; }
        public string imdb_code { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public float rating { get; set; }
        public int runtime { get; set; }
        public string[] genres { get; set; }
        public string summary { get; set; }
        public string description_full { get; set; }
        public string language { get; set; }
        public string mpa_rating { get; set; }
        public string background_image { get; set; }
        public string background_image_original { get; set; }
        public string small_cover_image { get; set; }
        public string medium_cover_image { get; set; }
        public string large_cover_image { get; set; }
        public string state { get; set; }
        public TorrentDTO[] torrentDTOs { get; set; }
        public int date_uploaded_unix { get; set; }
    }
}
