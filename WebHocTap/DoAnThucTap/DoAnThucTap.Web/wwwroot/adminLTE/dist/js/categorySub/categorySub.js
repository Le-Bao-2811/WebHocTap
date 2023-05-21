$(".js-addorupdate").click((ev) => {
    $(".modal-AddorUpdate").html("");

    var id = ev.currentTarget.getAttribute("data-id")
    if (id != null) {
        $("#exampleModalLabel").html("Sửa danh mục bài học")
        $.get("/admin/CategorySub/_Update/" + id, (ev) => {
            $(".modal-AddorUpdate").append(ev);
        })
    } else {
        $("#exampleModalLabel").html("Thêm danh mục bài học")
        $.get("/admin/CategorySub/_Create", (ev) => {
            $(".modal-AddorUpdate").append(ev);
        })
    }
})

$(".js-postdata").click(() => {
    var data = $(".id-categorysub").val()
    if (data == "") {
        var model = $("form").serialize();
        var formAction = $(this).attr("action");
        var fdata = new FormData();

        var fileInput = $('.image')[0];
        var file = fileInput.files[0];
        fdata.append("Image", file);
        console.log(fdata)

        // You can update the jquery selector to use a css class if you want
        $("input[type='text'").each(function (x, y) {
            fdata.append($(y).attr("name"), $(y).val());
        });
        $("input[type='checkbox'").each(function (x, y) {
            fdata.append($(y).attr("name"), $(y).val());
        });
        // gửi data
        $.ajax({
            type: 'post',
            url: "/admin/CategorySub/_Create",
            data: fdata,
            processData: false,
            contentType: false
        }).done(function (result) {
            // do something with the result now
            if (result == true) {
                window.location.reload();
            }
        });
        //$.post("/admin/CategorySub/_Create", model, (res) => {
        //    if (res == true) {
        //        window.location.reload();
        //    }
        //})
    } else {
        var model = $("form").serialize();
        $.post("/admin/CategorySub/_Update", model, (res) => {
            if (res == true) {
                window.location.reload();
            }
        })
    }

})