const updateForm = document.getElementById("updateForm");
updateForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const productId = document.getElementById("productId")
    const productName = document.getElementById("productName");
    const productDescription = document.getElementById("productDescription");
    const originalPrice = document.getElementById("originalPrice");
    const retailPrice = document.getElementById("retailPrice");
    const quantity = document.getElementById("quantity");
    const imageUrl = document.getElementById("imageUrl");
    const categoryId = document.getElementById("categoryId");


    if (
        productId !== null &&
        productName !== null &&
        productDescription !== null &&
        originalPrice !== null &&
        retailPrice !== null &&
        quantity !== null &&
        imageUrl !== null &&
        categoryId !== null
    ) {
        let input = {
            productId: productId.value,
            productName: productName.value,
            productDescription: productDescription.value,
            originalPrice: originalPrice.value,
            retailPrice: retailPrice.value,
            quantity: quantity.value,
            imageUrl: imageUrl.value,
            categoryId: categoryId.value,
        };

        axios.post('/api/product/update', input)
            .then(function () {
                window.location.assign("/product/");
            })
            .catch(function (error) {
                console.log(error);
            });
    }
});