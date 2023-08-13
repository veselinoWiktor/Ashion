function AddToLikedProducts(type, id) {
    fetch("https://localhost:7082/likes/Like/" + id + "?type=" + type, {
        method: "POST",
        credentials: "same-origin",
        headers: {
            "X-ANTI-FORGERY-TOKEN": document.getElementsByName("__RequestVerificationToken")[0].value
        }
    }).catch(function() {
        fetch("https://localhost:7082/Home/Error?statusCode=400", {
            method: "GET",
            mode: "cors",
            credentials: "same-origin",
            headers: {
                "X-ANTI-FORGERY-TOKEN": document.getElementsByName("__RequestVerificationToken")[0].value
            }
        });
    });
};