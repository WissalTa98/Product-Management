window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operation Successful", { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, "Operation Failed", { timeOut: 5000 });
    }
}

window.ShowSweetAlert = (type) => {
    if (type === "success") {
        Swal.fire(
            'Success Notification!',
            'Task completed successfully!',
            'success'
        );
    } else if (type === "error") {
        Swal.fire(
            'Error Notification!',
            'Task failed!',
            'error'
        );
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}
