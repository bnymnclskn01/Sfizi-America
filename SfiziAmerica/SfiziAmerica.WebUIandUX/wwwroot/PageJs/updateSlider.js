$('#form-submit').submit(function (e) {
    e.preventDefault();
    const ckData = CKEDITOR.instances.Description.getData();
    if (ckData.length < 1) {
        alert('Açıklama kısmı boş bırakılamaz')
        return
    }
    const activeValue = Number($('select[name=IsActive]').val())
    const fdata = new FormData();
    const fileInput1 = $('input[name=ImageVideoUrl]')[0];
    const file1 = fileInput1.files[0];
    //const fileInput2 = $('input[name=VideoUrl]')[0];
    //const file2 = fileInput2.files[0];

    fdata.append("ImageVideoUrl", file1);
    //fdata.append("VideoUrl", file2);
    fdata.append('ID', $('input[name=ID]').val())
    fdata.append('Title', $('input[name=Title]').val())
    fdata.append('Rank', $('input[name=Rank]').val())
    fdata.append('Description', ckData)
    fdata.append('IsActive', activeValue === 1 ? true : false)

    addRequest(fdata)
})

function addRequest(fdata) {
    $.ajax({
        url: '/admin/slider-guncelle/',
        processData: false,
        contentType: false,
        type: 'POST',
        data: fdata,
        success: (response) => {
            Swal.fire({
                title: 'Başarıyla Güncellendi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/slider-listele"
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