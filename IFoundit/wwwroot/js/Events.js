
$(document).ready(function () {
    $('input:radio[name=bedStatus]:checked').change(function () {
        if ($("input[name='bedStatus']:checked").val() == 0) {
            $("#contenido").html("<b>No tiene whatsapp!</b>");
        }
        if ($("input[name='bedStatus']:checked").val() == 1) {
            $("#contenido").html("<b>Tiene whatsap!</b>");
        }
    });
});