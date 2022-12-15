CKEDITOR.replace('Description');
$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData = CKEDITOR.instances.Description.getData();
    if (ckData.length < 1) {
        alert('Açıklama kısmı boş bırakılamaz')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    const fileInput1 = $('input[name=ImageUrl]')[0];
    const file1 = fileInput1.files[0];

    fdata.append("ImageUrl", file1);
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('ShortDescription', $('textarea[name=ShortDescription').val())
    fdata.append('Description', ckData)
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/hakkimizda-ekle',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Başarıyla Eklendi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/hakkimizda-listele"
                }
            })
        },
        error: (response) => {
            Swal.fire({
                title: 'Hata!',
                text: response.responseJSON.errorMessage,
                icon: 'error',
                confirmButtonText: 'Tamam'
            })
        }
    })
}