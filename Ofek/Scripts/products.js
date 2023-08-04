function getAjax(url) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url,
            success: data => {
                resolve(data);
            },
            error: err => {
                reject(err);
            }
        })
    });
}

function postAjax(url, dataOject) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url,
            type: "POST",
            data: dataOject,
            success: data => {
                resolve(data);
            },
            error: err => {
                reject(err);
            }
        })
    });
} 

//btnUsers

$(function () {
    $("#btnUsers").on("click",async function () {
        const url = "/home/getUsers";
        const productId = $("#ProductID").val();
        const data = await postAjax(url, { id: productId });
        $("#MainContent").html(data);


    });
});

$(function () {
    $("#btnProducts").on("click", async function () {
        const url = "/home/getPruducts";
        const customerId = $("#CustomerID").val();
        const data = await postAjax(url, { id: customerId });
        $("#MainContent").html(data);


    });
});