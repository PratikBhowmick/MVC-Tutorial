function clearFields()
{
    $('#Name').val('');
    $('#Price').val('');
    $('#Quantity').val('');
    $('.text-danger').html(null);

    $('#Name').removeClass("invalidFields");
    //return false;
}


function validateFields()
{
    if ($('#Name').val() == "")
    {
        $('#Name').addClass("invalidFields");
    }
}