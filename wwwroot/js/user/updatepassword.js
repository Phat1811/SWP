const formUpdatePassword = document.getElementById("formUpdatePassword");
formUpdatePassword?.addEventListener("submit", function (event) {
        event.preventDefault();
    const password = document.getElementById("password");
    const newpassword = document.getElementById("newPassword");
    const confirmnewpassword = document.getElementById("confirmNewPassword");

    if (
        password !== null &&
        newpassword !== null &&
        confirmnewpassword !== null
        ) {
                let input = {
                    password: password.value,
                    newpassword: newpassword.value,
                    confirmnewpassword: confirmnewpassword.value
                    
                };

                axios.post('/api/user/password', input)
                .then(function () {
                    window.location.assign("/auth/login");
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
});