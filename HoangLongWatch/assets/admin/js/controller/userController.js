var user = {
    init: function () {
        user.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/User/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.status === true) {
                        btn.text('Kích hoạt');
                        btn.addClass("text-success");
                        btn.removeClass("text-danger");
                    } else {
                        btn.text('Khoá');
                        btn.addClass("text-danger");
                        btn.removeClass("text-success");
                    }
                }
            });
        })
    }
}

user.init();