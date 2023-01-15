
$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    fdata.append('IsActive', activeValue === 1 ? true : false)
    fdata.append('PageName', $('select[name=PageName]').val())

    //Seo
    $('[name^="seo"]').each(function (x, y) {
        fdata.append($(y).attr("name"), $(y).val());
    });

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/seo-yonetimi-ekle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Added Successfully!',
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