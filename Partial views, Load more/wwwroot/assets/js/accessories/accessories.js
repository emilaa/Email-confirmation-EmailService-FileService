"use strict"
$(function () {

    let scrollSection = document.getElementById("scroll-section");

    window.onscroll = function () { scrollFunction() };

    function scrollFunction() {
        if (document.body.scrollTop > 195 || document.documentElement.scrollTop > 195) {
            scrollSection.style.top = "0";
        } else {
            scrollSection.style.top = "-62px";
            $("div").removeClass("inActive");
        }
    }

    $(document).on("click", ".show-more button", function () {

        let parent = $("#parent-products")

        let skipCount = $("#parent-products").children().length;

        let productCount = $("#product-count").val();

        $.ajax({
            /* url: `/accessories/loadmore?skip=${skipCount}`,*/
            url: "/accessories/loadmore",
            type: "Get",
            data: {
                skip: skipCount
            },
            success: function (res) {

                $(parent).append(res);

                skipCount = $("#parent-products").children().length;

                if (skipCount >= productCount) {

                    $(".show-more button").addClass("d-none");

                }
            }
        })
    })
});

let basketBtns = document.querySelectorAll(".add-product a");

let products = [];

if (localStorage.getItem("products") != null) {
    products = JSON.parse(localStorage.getItem("products"))

}



basketBtns.forEach(basketBtn => {
    basketBtn.addEventListener("click", function (e) {
        e.preventDefault();

        let productImage = this.parentNode.parentNode.parentNode.firstElementChild.lastElementChild.getAttribute("src");

        let productName = this.parentNode.nextElementSibling.innerText;

        let productCost = this.parentNode.nextElementSibling.nextElementSibling.innerText;

        let productId = parseInt(this.parentNode.parentNode.parentNode.getAttribute("product-id"));

        let existProduct = products.find(m => m.id == productId);
        let deleteProduct = products.delete;

        if (existProduct != undefined) {
            existProduct.count += 1;
        } else {
            products.push({
                id: productId,
                name: productName,
                cost: productCost,
                image: productImage,
                count: 1,
            })

            // Swal.fire({
            //     position: "top-center",
            //     icon: "success",
            //     title: "Product added",
            //     showConfirmButton: false,
            //     timer: 1000,
            //   });


        }


        localStorage.setItem("products", JSON.stringify(products));
        document.querySelector("sup").innerText = products.length;


    })

});


document.querySelector("sup").innerText = getProductsCount(products);
function getProductsCount(items) {
    let resultCount = 0;
    for (const item of items) {
        resultCount += item.count
    }
    return resultCount;
}
function getDeleteCount(items) {
    let resultCount = 0;
    for (const item of items) {
        resultCount -= 1;
    }
    return resultCount;
}
