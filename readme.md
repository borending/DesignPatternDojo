## �]�p�Ҧ��׽m��
���M�׬����H�U�����Ҷi�檺�]�p�Ҧ��m��
https://www.dofactory.com/net/design-patterns

�]�p�Ҧ��O��󪫥�ɦV������
�G�ǲߪ����Ǭ��G����ɦV��¦�έ�h > �]�p�Ҧ�
����ɦV��¦���ʸˡB�~�ӵ���... ���h�������A�����q����ɦV��hSOLID �}�l


## 1. ����ɦV��h�GSOLID
### ��@¾�d SRP (Single Responsibility Principle)
>�@�ӼҲ����ӥu��@�Ө���(�欰)�ӧ��ܡC
1. �@�����O�Τ@�Ӥ�k�A�u�B�z�@�ط~���޿�
�Ҧp�G�@�ӦW��SendMail ����k�A�̭��u���H�H�ʧ@�F�@�ӦW��PdfService �����O�A�̭��u���Ѿާ@PDF�������\��
2. �ⴣ�Ѭ����\�઺�{���X���E�b�@�_�A�Φ��Ҳ�
�Ҧp�G"�B�z�q��"��"�H�H"�\���@�b���P�����O(Service)�C
3. �������P�Ҳ�(����) �ϥΪ��{���X�A�H�K�ק�{������]�����X�y���D�w�������~�C
�Ҧp�G��ӼҲզ@�Ψ쪺�{���A�]���Y�@�ӼҲժ��ݨD�ӭק�ɡA�N��@�ε{���X�����C

SRP�����I���N�O�����������A�n�`�N�������n�L�ӡA�H�K�y���}�o�L������C
https://medium.com/�{���R�n��/�ϤH�ƨg��-solid-��h-��@¾�d��h-single-responsibility-principle-c2c4bd9b4e79

### �}��ʳ� OCP (Open-Closed Principle)_____________[�ݸɥR]
>�z�L���c���]�p�A�Ϩ��z�L�s�W�{�����ܧ�t�Υ\��Φ欰�A�Ӥ��ݭn�ק�즳���{��
�t�ά[�c�|�H���h�Ӱ������A�ϸ������h(�֤�)�������|�]���C���h(�~��)���ק�Ө���v�T

1. �z�L���g�s�{���X�A�H�s�W�\��
2. ����A �ݭn�Ψ�즳����B ���{���A�h�ϥΤ����`�JB ����A�O�@B ����즳�޿�H�K����v�T
���ɤ������Y��A �̿��B ����V�̿�A�GA ���ק藍�|���ʨ�B ���즳�{��

�}��(��H���O��k�B�����B�x����)�X�W�A�ʳ�(�B�z�y�{�޿誺)�ק�C
https://medium.com/@f40507777/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87-open-closed-principle-31d61f9d37a5
https://medium.com/�{���R�n��/�ϤH�ƨg��-solid-��h-�}��ʳ���h-open-closed-principle-f7eaf921eb9c
https://igouist.github.io/post/2020/10/oo-11-open-closed-principle/

### ������� LSP (Liskov Substitution Principle)
>�YB �OA ���l���A�A�hB �n�৹�����NA ���\��C
�G�N�����A�������l���A��A�즳���{�����ݧ��ܡA�]���|�o�ͥ�����~�β��`�C

1. ������󤣥i�H�j�ơG��J��e�A�ѼƩέ�����Ӥ�����O�h
�Ҧp�G�����A�n�D��J���׳̪�50 ���r��A�h�l���A���n�D���פ���p��50
�_�h�������l���A��A�쥻���X�k��J�|���Ϳ��~���G
2. ������󤣥i�H�z�ơG��X���Y�A�^�X�����Ӥ�����A��
�Ҧp�G�|����G�����O"�T��"�A�����A��X���~"�G��"�A�h�l���A����X�����e��"�T��"
�_�h�������l���A��A�쥻����"�G��"���a�讳��"�|��"�|���Ϳ��~���G

�쥻��LSP �u�����~�Ӱ��D�A��ӭl�ͨ줶���ι�@�]�A�Φ���h�C
�Ƶ��G���LSP��h�ӬݡA�~�Ӯ����ӭn��ҳo�Ӥl���O�ण�వ������O���檺�欰�A���n�]����¬��Freuse ���~�ӡC
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