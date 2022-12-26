$('.btnDelete').click(function (e) {
    e.preventDefault()
    const id = $(this).data('id')
    Swal.fire({
        title: 'Silmek istediğinize emin misiniz?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Evet!',
        cancelButtonText: 'Hayır'
    }).then((result) => {
        if (result.isConfirmed) {
            deleteRequest(id)
        }
    })
})

function deleteRequest(id) {
    $.ajax({
        url: '/admin/hr-formu-sil/' + id,
        type: 'POST',
        success: (res) => {
            Swal.fire({
                title: 'Başarıyla Silindi!',
                icon: 'success',
                confirmButtonText: 'Tamam'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/admin/hr-formu-listele"
                }
            })
        },
        error: (res) => {
            Swal.fire({
                title: 'Silme işlemi sırasında bir hata oluştu!',
                icon: 'error',
                confirmButtonText: 'Tamam'
            })
        }
    })
}