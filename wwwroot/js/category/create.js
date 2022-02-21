const createForm = document.getElementById("createForm");
createForm?.addEventListener("submit", function (event) {
        event.preventDefault();
        const name = document.getElementById("name");
        const description = document.getElementById("description");

        if (
                name !== null &&
                description !== null
        ) {
                let input = {
                    name: name.value,
                    description: description.value,                
                };

                axios.post('/api/category/create', input)
                .then(function () {
                    window.location.assign("/category");
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
});