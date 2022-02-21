const formUpdateUser = document.getElementById("formUpdateUser");
formUpdateUser?.addEventListener("submit", function (event) {
        event.preventDefault();
    const name = document.getElementById("name");
    const phone = document.getElementById("phone");
    const address = document.getElementById("address");
    const email = document.getElementById("email");

        if (
            name !== null &&
            phone !== null &&
            address !== null &&
            email !== null &&
        ) {
                let input = {
                    name: name.value,
                    phone: phone.value,
                    address: address.value,
                    email: email.value,
                };

                axios.post('/api/user/info', input)
                .then(function () {
                    window.location.assign("/");
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
});