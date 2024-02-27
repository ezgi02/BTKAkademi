using BTKAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTKAkademi.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index1()
        {
            string mesaj = $"bugunun tarihi {DateTime.Now.ToString()}";
            return View("Index1",mesaj);//String ifade içermez IOCtion Result ifadesi
        }
        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };

            return View(names);//View
        }
        public IActionResult Index3()//hem content hen-m viewi içeriir
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Ahmet",LastName="Can",Age=20 },
                new Employee(){Id=2,FirstName="Veli",LastName="Dağ",Age=30 },
                new Employee(){Id=3,FirstName="Mehmet",LastName="Ziya",Age=45 }
            };
            return View("Index3",list);//Content **ContentResult demek daha mantıklı
        }

    }
}


/*
 // ViewResult kullanarak HTML içeriği döndürme
        public ViewResult Index()
        {
            // Index.cshtml adında bir görünüm dosyası bulunuyorsa, bu görünümün HTML içeriğini döndürür.
            return View("Index");
        }

        // ContentResult kullanarak metin içeriği döndürme
        public ContentResult Text()
        {
            return Content("Hello, world!"); // Tarayıcıya "Hello, world!" metnini gönderir.
        }

        // RedirectResult kullanarak yönlendirme yapma
        public RedirectResult RedirectExample()
        {
            return Redirect("https://www.example.com"); // Tarayıcıyı belirtilen URL'ye yönlendirir.
        }

        // JsonResult kullanarak JSON veri döndürme
        public JsonResult JsonData()
        {
            var data = new { Name = "John", Age = 30 };
            return Json(data); // JSON formatında { "Name": "John", "Age": 30 } verisini döndürür.
        }
 
 */