<?php

require_once 'index.php';

class Motocykle extends BazaDanych
{
    public function pobierz()
    {
        /* Select queries return a resultset */
        if ($result = $this->conn->query('SELECT * FROM motocykle LIMIT 10')) {
            $motocykle = $result->fetch_assoc();
            /* free result set */
            $result->close();

            return $motocykle;
        }
    }
}
$mn = new Motocykle('192.168.1.12', 'root', 'kornelius', 'dominik');
print_r($mn->pobierz());

//
// $aa->asd();
// $aa->asaaa;
// $aaeee = $aa;
// $aasdasd = $aa->asd();
// $aasdasd = $aa->sfgdfg;
// $sdavdf->asdf->asdadfgf->asdfsefr = '123';
// $aaaa = $sdavdf->asdf->asdadfgasd()->asdfasdf;

