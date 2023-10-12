(function ($) {
    var nextElement = $('#image-urls div:last-of-type');
    var next = parseInt($(nextElement).attr('id').charAt($(nextElement).attr('id').length - 1));
    $("#add-more").click(function (e) {
        e.preventDefault();
        var addto = "#field" + next;
        var addRemove = "#field" + (next);
        next = next + 1;
        var newIn = '<div class="form-inline col-md-9 px-0" id="field' + next + '" name="field' + next + '"><input class="form-control col-md-12" value="" type="text" data-val="true" data-val-required="The Images field is required." id="ImageUrls" name="ImageUrls"><br /><br /></div>';
        var newInput = $(newIn);
        var removeBtn = '<button id="remove' + (next - 1) + '" class="btn btn-danger col-md-3 remove-me" >Remove</button>';
        var removeButton = $(removeBtn);
        $(addto).after(newInput);
        $(addRemove).after(removeButton);
        $("#field" + next).attr('data-source', $(addto).attr('data-source'));
        $("#count").val(next);

        $('.remove-me').click(function (e) {
            e.preventDefault();
            var fieldNum = this.id.charAt(this.id.length - 1);
            var fieldID = "#field" + fieldNum;
            $(this).remove();
            $(fieldID).remove();
        });
    });

    $('.remove-me').click(function (e) {
        e.preventDefault();
        var fieldNum = this.id.charAt(this.id.length - 1);
        var fieldID = "#field" + fieldNum;
        $(this).remove();
        $(fieldID).remove();
    });

    $(function () {
        $('[data-toggle="popover"]').popover({
            container: 'body',
            trigger: 'focus'
        });
    });
})(jQuery)