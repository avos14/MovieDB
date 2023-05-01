function ajaxCall(method, api, data, successCB, errorCB) {
    console.log("performing ajax call to " + api)
    $.ajax({
        type: method,
        url: api,
        data: data,
        cache: false,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: successCB,
        error: errorCB
    });
}