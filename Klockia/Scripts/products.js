$(document).ready(function () {
    // Detta körs när sidan har laddats

    $(".productContainer").on("click", function () {
        var id = $(this).attr("id");

        var productList = [];

        // Skriv inte över lista, bygg på den istället
        if (localStorage.getItem("cart") != null) {
            productList = JSON.parse(localStorage.getItem("cart"));
        }

        // Uppdatera antalet produkter för objekten i listan, istället för att lägga till nya objekt
        var isfound = false;
        for (var i = 0; i < productList.length; i++) {
            if (productList[i].productId == id) {
                productList[i].amount++;
                isfound = true;
            }
        }

        if (isfound == false) {
            productList.push({ productId: id, amount: 1 });
        }

        localStorage.setItem("cart", JSON.stringify(productList));

    });

    $(".buy").on("click", function () {
        $.ajax({
            url: "/Home/CreateOrder",
            method: "POST",
            contentType: "application/json;odata=verbose",
            data: localStorage.getItem("cart"),
            success: function (result) {
                $(".alert-success").show();
            },
            error: function (error) {
                $(".alert-danger").show();
            }
        });
    });

    //skickar mig till till metoden createorder som ligger i home controller

    $(".checkout").on("click", function () {
        // location.href = "/cart/createorder";
    });

    $("#hiddenCart").val(localStorage.getItem("cart"));
});