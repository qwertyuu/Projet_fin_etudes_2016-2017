(function() {
    $(function() {

        var _userService = abp.services.app.user;
        var _$modal = $('#UserCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var user = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            
            abp.ui.setBusy(_$modal);
            _userService.createUser(user).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        $('form.modal-content').submit(function () {
            var re = /^\d{4}\/\d{2}\/\d{2}$/;

            return re.test(this.filtre_debut.value ? this.filtre_debut.value : "0001/01/01") &&
            re.test(this.filtre_fin.value ? this.filtre_fin.value : "0001/01/01");
        });
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
    });
})();