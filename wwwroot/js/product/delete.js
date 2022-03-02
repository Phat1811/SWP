const deleteForm = document.getElementById("deleteForm");
deleteForm?.addEventListener("submit", function (event) {
    const productId = document.getElementById("productId");

    if (
        productId !== null
    ) {
        let input = {
            productId: productId.value,
        };

        http.post('/api/product/delete', input)
            .then(() => window.location.assign("/product"))
            .catch(function (error) {
                console.log(error);
            });
    }
});