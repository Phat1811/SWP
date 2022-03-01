
const pageChange = () => {
        const paginationSize = document.getElementById("pagination-size");
        const paginationBtn = document.getElementById("pagination-btn");

        paginationSize?.addEventListener("change", function (_) {
                var option = paginationSize.options[paginationSize.selectedIndex];

                const pageSizeInput = document.getElementById("pageSize") ;
                pageSizeInput.value = option.value;

                const pageIndexInput = document.getElementById("pageIndex");
                pageIndexInput.value = "0";

                const form = document.getElementById("formFilter");
                form.submit();
        });

        const pageBtn = paginationBtn?.getElementsByTagName("button");

        if (pageBtn) {
                for (let index = 0; index < pageBtn.length; index++) {
                        const element = pageBtn[index];
                        element.addEventListener("click", function (_) {
                                const pageIndexInput = document.getElementById("pageIndex");

                                const value = element.getAttribute("data-index");
                                if (value) {
                                        pageIndexInput.value = value;
                                }
                                const form = document.getElementById("formFilter");
                                form.submit();
                        });
                }
        }
};