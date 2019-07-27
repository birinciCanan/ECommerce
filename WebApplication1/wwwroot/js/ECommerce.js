var ECommerce = {
    page: {
        Home: {

        },
        Category: {
            Save: function () {
                var categoryId = $("#CategoryId").val();
                var productName = $("#ProductName").val();
               // alert("save çalıştı");

                var jsonObj = new Object();
                jsonObj.categoryId = categoryId;
                jsonObj.productName = productName;

                var json = JSON.stringify(jsonObj); //obje olan json nu string bir veriye çevirir.

                $.ajax({      //$=juery ajax=api =alttaki kodu çalıştıran bır ust yüklenıcı
                    method: "POST",
                    url: "/api",
                    data: "JSON=" + json
                })
                    .done(function (msg) {
                        alert("Data Saved: " + msg);
                    });

            }
        },
        Contact: {

        },
        Help: {

        }
    }
}