$('#form-submit').submit(function (e) {
    e.preventDefault();
    const activeValue = Number($('select[name=IsActive]').val())
    const payload = {
        Title: $('input[name=Title]').val(),
        Icon: $('select[name=Icon]').val(),
        Url: $('input[name=Url]').val(),
        IsActive: activeValue === 1 ? true : false,
    }
    addRequest(payload)
})

function addRequest(payload) {
    $.ajax({
        url: '/admin/sosyal-medya-ekle',
        type: 'POST',
        data: payload,
        success: () => {
            Swal.fire({
                title: 'Başarıyla Eklendi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/sosyal-medya-listele"
                }
            })
        },
        error: () => {
            Swal.fire({
                title: 'Hata!',
                text: response.responseJSON.errorMessage,
                icon: 'error',
                confirmButtonText: 'Tamam'
            })
        }
    })
}