function clearFields()
{
    $('#Name').val('');
    $('#Price').val('');
    $('#Quantity').val('');
    $('.text-danger').html(null);

    $('#Name').removeClass("invalidFields");
    $('#Quantity').removeClass("invalidFields");
    //return false;
}


function validateFields()
{
    if ($('#Name').val() == "")
    {
        $('#Name').addClass("invalidFields");
    }

    if ($('#Quantity').val() < 1 || $('#Quantity').val() > 50) {
        $('#Quantity').addClass("invalidFields");
    }
    //document.getElementById('Term')
    if (!document.getElementById('Term').checked)
    {
        document.getElementById('termCheckMessage').style.display = 'block';
    }
}