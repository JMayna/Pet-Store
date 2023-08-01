using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store
{
    //HomeWork 2: Step 1
    public class ProductLogic
    {
        //HomeWork 2: Step 2
        private List<Product> _products;
        //HomeWork 2: Step 10
        private Dictionary<string, DogLeash> _dogleashs = new Dictionary<string, DogLeash>();

        private  Dictionary<string, CatFood> _catfoods = new Dictionary<string, CatFood>();

        //HomeWork 2: Step 3 (This is a constructor)
        public ProductLogic()
        {
            _products = new List<Product>();
            
        }
        //HomeWork 2: Step 4
        public void AddProduct(Product product)
        {
            //HomeWork 2: Step 5
            _products.Add(product);
            //HomeWork 2: Step 11 
            if (product is DogLeash)
            {
               _dogleashs.Add(product.Name, product as DogLeash);
            }

            else if (product is CatFood)
            {
                _catfoods.Add(product.Name, product as CatFood);
            }

           
        }
        //HomeWork 2: Step 6
        public List<Product> GetAllProdcuts()
        {
            return _products; 
        }

        
        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                
                return _dogleashs[name];
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }      
    }
}
