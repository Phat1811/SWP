const deleteForm = document.getElementById("deleteForm");
deleteForm?.addEventListener("submit", function (event) {
    event.preventDefault();
    const productId = document.getElementById("productId");
    if (productId !== null) {
        let input = {
            productId: productId.value,
        };

        http.post('#', input)
            .then(() => window.location.assign('/product'))
            .catch(function (error) {
                console.log(error);
            });
    }
});