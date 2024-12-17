using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PatkoStefaniaLab11.Models;


namespace PatkoStefaniaLab11.Data
{
    public interface IRestService
    {
       
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }

    }



