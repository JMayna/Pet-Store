using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store
{
    public class ProductLogic:IProductLogic
    {
        private List<Product> _products;

        private Dictionary<string, DogLeash> _DogLeashDict = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _CatFoodDict = new Dictionary<string, CatFood>();


        public ProductLogic()
        {

            _products = new List<Product>
            {
                new DogLeash
                {
                    Description = "An example descirption 1",
                    LengthInches = 60,
                    Material = "silk",
                    Name = "Silk dog leash",
                    Price = 5,
                    Quantity = 0,

                },
                new DogLeash
                {
                    Description = "An example descirption 2",
                    LengthInches = 50,
                    Material = "Not silk",
                    Name = "Not silk dogleash",
                    Price = 1,
                    Quantity = 1,
                }
            };
            
        }

        public void AddProduct(Product product)
        {

            _products.Add(product);

            if (product is DogLeash ) 
            {
                _DogLeashDict.Add(product.Name, product as DogLeash); 
            }
            else if (product is CatFood )
            {
                _CatFoodDict.Add(product.Name, product as  CatFood);
            }
                        
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _DogLeashDict[name];
            }
            catch(Exception ex) 
            {
                return null;
            }
        }
        public List<string> GetOnlyInStockProducts()
        {
            return _products.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
            
    }

}
