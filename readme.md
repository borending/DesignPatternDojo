## �]�p�Ҧ��׽m��
���M�׬����H�U�����Ҷi�檺�]�p�Ҧ��m��
https://www.dofactory.com/net/design-patterns

�]�p�Ҧ��O��󪫥�ɦV������
�G�ǲߪ����Ǭ��G����ɦV��¦�έ�h > �]�p�Ҧ�
����ɦV��¦���ʸˡB�~�ӵ���... ���h�������A�����q����ɦV��hSOLID �}�l


## 1. ����ɦV��h�GSOLID

### S ��@¾�d: �@�ӼҲ����ӥu��@�Ө���(�欰)�ӧ��ܡC
�{���X�̷ӼҲդ����A��������\�ྮ�E�b�@�_�C
�������P����ϥΪ��{���X�A�H�K�ק�{������]�����X�y���D�w�������~�C
�Ҧp�G
1. �q�� �� �H�H �\���@�b���P�����O(Service)�C
2. �@�����O�Τ@�Ӥ�k�A�u�B�z�@�ӷ~���޿�:
���]�{�����H�H��k(SendMail)�A�H���H�|�A��Windows TEMP �M���C�p�G���ӷs�ݨD���Ψ�H�H�\������ݭn�M��TEMP�A���~�ޥ�SendMail �o�Ӥ�k�N�i��|�y���t�Ω_�Ǫ�BUG(�p�G�O����w��ʪ��\��A�O�H�����|�Ψ��N�S�t)�C
���O��@¾�d�������N�O�����������A�n�`�N�������n�L�ӡA�H�K�y���}�o�L������C

### O �}��ʳ�: �z�L���c���]�p�A�Ϩ��z�L�s�W�{�����ܧ�t�Υ\��Φ欰�A�Ӥ��ݭn�ק�즳���{��
�t�ά[�c�|�H���h�Ӱ������A�ϸ������h(�֤�)�������|�]���C���h(�~��)���ק�Ө���v�T

���]�@�q�޿褤�w��A ���󪺳B�z�A�p�GA ���h��type�A�i�H��D�n�B�z�޿褤��A�A�ϥΤ����άO�x�����N�A�ӧOtype ���B�z�b�U�۪�����Τ�������@�C�Ҧp�GViewModel ����Build�C�p���@�ӷ�Type �W�[���ɭԡA�]���D�{���޿�Q��H�ƩҥH���έק�A�u�n�bType ����g�ݩ�L���޿�C
�}��(��H���O��k�B�����B�x����)�X�W�A�ʳ�(�B�z�y�{�޿誺)�ק�C
https://medium.com/@f40507777/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87-open-closed-principle-31d61f9d37a5

### L �������: �w���~�Ӫ���h�A�l���O�n�৹�����N�����O���\��C new 
### L : ���������h�A�~�ӮɡA�l���O�n�৹�����N�����O���\��C

�Ҧp : 
���@�Ӥ���"���X"�A�����O�~��"���X"�����A�갵���ɭԿ�J���w���ަסA��X��������z
��j�a�s�γo�Ӥ����A���M�����D�I��O�ֹ갵���A���O�w�g���w�n��ަ׶i�h�N�|�ܭ��z
�p�G���@�Ӥl���O�~�ӨýƼg"���X" �o�ӥ\��A���L����J��X�����n�ŦX�����O���w����J��X�A������u�H�U���� : 
a. ������ܿ�J���X�k�d�� : �Ҧp���୭��u���J�޽G�סA�p�G�@�˪������b���P�a��I�᪺�갵���@�ˮɡA�|�ܦ��ѼƦ��ɭԷ|�L�A���ɭԤ��|�L�C
b. �]������ܿ�X : ���M�l���O��X�����z�O�»����z�A���Y�����ȤH�|�ͮ� XD
c. �~�b���I�s����]�n�@�� : �����O�I��]�O�Q�ʸ˪��{���A�p�G�L�I�᭭���~�ॿ�`�u�@�A�o�b����I�s�l���O�A���i��|�y���D�w�������~

�ڬO�������աA�����n�Ƽg�N�n�աC
�٬O���A�i�H�}���X�W�A�W�[�s���ݩ� �s����k�A�����n���ܨӦۤ����O����k ?

�~�ӬO���Freuse �ҥHreuse ���a��N�����A�p�G�n��N�ݭn��abstract �ΥβզX��
https://igouist.github.io/post/2020/07/oo-4-inheritance/
https://medium.com/@f40507777/%E9%87%8C%E6%B0%8F%E6%9B%BF%E6%8F%9B%E5%8E%9F%E5%89%87-liskov-substitution-principle-adc1650ada53

### I �����j��: �קK�̿�󤣨ϥΪ��F��
Overloaded �n�Τ��P�����h�Ϥ�

### D �̿�ϦV: �Ӹ`���Ө̿�󵦲�  
ViewModel.Build �N�O�̿����

---

## 2. �]�p�Ҧ� Design Patterns
���X�F�U�ت���ɦV SOLID�]�p�ߪk�A�Ӳ��ͪ��]�p�W�d
�D�n�i�H�����T�j���G

1. �Ыث��Ҧ� Creational
2. ���c���Ҧ� Structural
3. �欰���Ҧ� Behavioral

�ܩ��㪺�A�q�U�۪��R�W�i�H�����X�ϥΪ�����

�ھڲέp�A�̱`�Ϊ��]�p�Ҧ����U�G

1. Singleton ���� v
2. Decorator ��
3. Command ����
4. Factory ( Action Mapping ) �� v
5. Observer ( Event Listener ) �� v
6. Strategy �� v
7. Builder ���C
8. Adapter ( asList , toString ) ����
9. State ��

References:
https://learningdaily.dev/the-7-most-important-software-design-patterns-d60e546afb0e?gi=45b79806400a
https://www.upgrad.com/blog/software-design-patterns/#Top_5_Popular_Software_Design_Patterns
https://www.quora.com/Which-are-the-most-useful-design-patterns