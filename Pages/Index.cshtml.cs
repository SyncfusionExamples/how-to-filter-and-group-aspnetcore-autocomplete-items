using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace autocomplete.Pages
{
    public class AutoCompleteDataModel
    {
        public string Id { get; set; }
        public string Vegetable { get; set; }
        public string Category { get; set; }

        public List<AutoCompleteDataModel> GetData()
        {
            List<AutoCompleteDataModel> AutoCompleteData = new List<AutoCompleteDataModel>()
            {
                new AutoCompleteDataModel() {  Id = "item1", Vegetable = "Cabbage", Category = "Leafy and Salad" },
                new AutoCompleteDataModel() {  Id = "item2", Vegetable = "Chickpea", Category = "Beans" },
                new AutoCompleteDataModel() {  Id = "item3", Vegetable = "Garlic", Category = "Bulb and Stem" },
                new AutoCompleteDataModel() {  Id = "item4", Vegetable = "Green bean", Category = "Beans" },
                new AutoCompleteDataModel() {  Id = "item5", Vegetable = "Horse gram", Category = "Beans" },
                new AutoCompleteDataModel() {  Id = "item6", Vegetable = "Onion", Category = "Bulb and Stem" },
                new AutoCompleteDataModel() {  Id = "item7", Vegetable = "Pumpkins", Category = "Leafy and Salad" },
                new AutoCompleteDataModel() {  Id = "item8", Vegetable = "Spinach", Category = "Leafy and Salad" },
                new AutoCompleteDataModel() {  Id = "item9", Vegetable = "Wheat grass", Category = "Leafy and Salad" },
                new AutoCompleteDataModel() {  Id = "item10", Vegetable = "Yarrow", Category = "Leafy and Salad" },
                new AutoCompleteDataModel() {  Id = "item11", Vegetable = "Garden Rocket", Category = "Leafy and Salad" }
                    };
            return AutoCompleteData;
        }
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
