$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())

    const fdata = new FormData();

    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('IsActive', activeValue === 1 ? true : false)
    fdata.append('PageName', $('select[name=PageName]').val())

    //Seo
    $('[name^="seo"]').each(function (x, y) {
        fdata.append($(y).attr("name"), $(y).val());
    });

    updateRequest(fdata)
})

function updateRequest(fdata) {
    $.ajax({
        url: '/admin/seo-yonetimi-guncelle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Successfully Updated!',
                icon: 'success',
                confirmButtonText: 'Ok'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/seo-yonetimi-listele"
                }
            })
        },
        error: (response) => {
            Swal.fire({
                title: 'Error!',
                text: response.responseJSON.errorMessage,
                icon: 'error',
                confirmButtonText: 'Ok'
            })
        }
    })
}