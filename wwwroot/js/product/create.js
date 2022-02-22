const createForm = document.getElementById("createForm");
createForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const name = document.getElementById("name");
    const description = document.getElementById("description");
    const originalPrice = document.getElementById("originalPrice");
    const retailPrice = document.getElementById("retailPrice");
    const quantity = document.getElementById("quantity");
    const imageUrl = document.getElementById("imageUrl");
    const categoryId = document.getElementById("categoryId");


    if (
        name !== null &&
        description !== null &&
        originalPrice !== null &&
        retailPrice !== null &&
        quantity !== null &&
        imageUrl !== null &&
        categoryId !== null
    ) {
        let input = {
            name: name.value,
            description: description.value,
            originalPrice: originalPrice.value,
            retailPrice: retailPrice.value,
            quantity: quantity.value,
            imageUrl: imageUrl.value,
            categoryId: categoryId.value,
        };

        axios.post('/api/product/create', input)
            .then(function () {
                window.location.assign("/product/");
            })
            .catch(function (error) {
                console.log(error);
            });
    }
});