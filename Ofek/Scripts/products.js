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



$(function () {
    $(".productInfo").on("click", async function () {
        const url = "/home/getPruducts";
        const customerId = $(this).attr("id");
       // alert(customerId);

        const data = await postAjax(url, { id: customerId });
        $("#MainContent").html(data);


    });

  


});