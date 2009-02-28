using TaikodomStats.DataSL;
namespace TaikodomStats.DataSL
{
    public static class InstanciateData
    {
        public static Career[] GetCareers()
        {
            if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "pt-BR")
            {
                #region Career base

                var hotShot = new Career("Ás", 69);
                var batedor = new Career("Explorador", 69);
                var bomber = new Career("Demolidor", 69);
                var cargueiro = new Career("Mercador", 69);

                #endregion

                #region skill base

                var pilotagem = new Skill("Pilotagem");
                var afterburn = new Skill("Afterburn");
                var canhoneiro = new Skill("Canhoneiro");
                var escudoSuperior = new Skill("Escudo Superior");
                var misseis = new Skill("Demolição : Mísseis");
                var foguetes = new Skill("Demolição : Foguetes");
                var rail = new Skill("Artilharia : Rail");
                var gaus = new Skill("Artilharia : Gauss");
                var particulas = new Skill("Artilharia : Partículas");
                var magnetica = new Skill("Artilharia : Magnética");
                var balistica = new Skill("Artilharia : Balística");
                var plasma = new Skill("Artilharia : Plasma");
                var scatter = new Skill("Artilharia : Scatter");
                var neutron = new Skill("Artilharia : Neutron");
                var emboscar = new Skill("Emboscar");
                var blaster = new Skill("Artilharia : Blaster");
                var gerenciamento = new Skill("Gerenciamento Energético");
                var antiradiacao = new Skill("Anti-Radiação");
                var mina = new Skill("Demolição : Minas");
                var otimizacao = new Skill("Otimização de Conteiner");
                var cofre = new Skill("Cofre");
                var especialista = new Skill("Especialista em Minas");
                var casco = new Skill("Casco Superior");
                var omega = new Skill("OmegaStrike");
                var especdemoli = new Skill("Especialista em Demolição");
                var torpedo = new Skill("Demolição : Torpedos");

                #endregion

                #region hotshot base

                hotShot.AddSkillPoint(pilotagem, 1, "Habilita Caça Básico");
                hotShot.AddSkillPoint(pilotagem, 2, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 3, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 4, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 5, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 6, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 7, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 8, "Habilita Caça Intermediário");
                hotShot.AddSkillPoint(pilotagem, 9, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 10, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 11, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 12, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 13, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 14, "+ 3% Escudo, 2% Aceleração, 1% Velocidade");
                hotShot.AddSkillPoint(pilotagem, 15, "Habilita Caça Avançado");

                hotShot.AddSkillPoint(gaus, 1, "Habilita Gauss Básico");
                hotShot.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo");
                hotShot.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado");

                hotShot.AddSkillPoint(magnetica, 1, "Habilita Magnético Básico");
                hotShot.AddSkillPoint(magnetica, 2, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 3, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 4, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 5, "Habilita Magnético Duplo");
                hotShot.AddSkillPoint(magnetica, 6, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 7, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 8, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 9, "+ 3% Cadência, 3% velocidade projétil");
                hotShot.AddSkillPoint(magnetica, 10, "Habilita Magnético Avançado");

                hotShot.AddSkillPoint(afterburn, 1, "+ 2% Velocidade, 1 segundo duração");
                hotShot.AddSkillPoint(afterburn, 2, "+ 2% Velocidade, 1 segundo duração");
                hotShot.AddSkillPoint(afterburn, 3, "+ 2% Velocidade, 1 segundo duração");
                hotShot.AddSkillPoint(afterburn, 4, "+ 2% Velocidade, 1 segundo duração");
                hotShot.AddSkillPoint(afterburn, 5, "+ 2% Velocidade, 1 segundo duração");

                hotShot.AddSkillPoint(rail, 1, "Habilita Rail Básico");
                hotShot.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 5, "Habilita Rail Duplo");
                hotShot.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(rail, 10, "Habilita Rail Avançado");

                hotShot.AddSkillPoint(particulas, 1, "Habilita Partículas Básico");
                hotShot.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo");
                hotShot.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance");
                hotShot.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado");

                hotShot.AddSkillPoint(escudoSuperior, 1, "+ 5% escudo, 4 regeneração");
                hotShot.AddSkillPoint(escudoSuperior, 2, "+ 5% escudo, 4 regeneração");
                hotShot.AddSkillPoint(escudoSuperior, 3, "+ 5% escudo, 4 regeneração");
                hotShot.AddSkillPoint(escudoSuperior, 4, "+ 5% escudo, 4 regeneração");
                hotShot.AddSkillPoint(escudoSuperior, 5, "+ 5% escudo, 4 regeneração");

                hotShot.AddSkillPoint(canhoneiro, 1, "+ 3% dano");
                hotShot.AddSkillPoint(canhoneiro, 2, "+ 3% dano");
                hotShot.AddSkillPoint(canhoneiro, 3, "+ 3% dano");
                hotShot.AddSkillPoint(canhoneiro, 4, "+ 3% dano");
                hotShot.AddSkillPoint(canhoneiro, 5, "+ 3% dano");

                hotShot.AddSkillPoint(misseis, 1, "Habilita Lançador categoria Míssel Leve");
                hotShot.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência");
                hotShot.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência");
                hotShot.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência");
                hotShot.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência");

                hotShot.AddSkillPoint(foguetes, 1, "Habilita Lançador categoria Foguete");
                hotShot.AddSkillPoint(foguetes, 2, "+ 2% dano");
                hotShot.AddSkillPoint(foguetes, 3, "+ 2% dano");
                hotShot.AddSkillPoint(foguetes, 4, "+ 2% dano");
                hotShot.AddSkillPoint(foguetes, 5, "+ 2% dano");

                hotShot.AddSkillPoint(balistica, 1, "Habilita Balístico Básico");
                hotShot.AddSkillPoint(balistica, 2, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 3, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 4, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 5, "Habilita Balístico Duplo");
                hotShot.AddSkillPoint(balistica, 6, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 7, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 8, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 9, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(balistica, 10, "Habilita Balístico Avançado");

                hotShot.AddSkillPoint(plasma, 1, "Habilita Plasma Básico");
                hotShot.AddSkillPoint(plasma, 2, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 3, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 4, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 5, "Habilita Plasma Duplo");
                hotShot.AddSkillPoint(plasma, 6, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 7, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 8, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 9, "+ 2% dano, 4% cadência");
                hotShot.AddSkillPoint(plasma, 10, "Habilita Plasma Avançado");

                hotShot.AddSkillPoint(blaster, 1, "Habilita Blaster Básico");
                hotShot.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo");
                hotShot.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil");
                hotShot.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado");

                hotShot.AddSkillPoint(neutron, 1, "Habilita Neutron Básico");
                hotShot.AddSkillPoint(neutron, 2, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 3, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 4, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 5, "Habilita Neutron Duplo");
                hotShot.AddSkillPoint(neutron, 6, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 7, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 8, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 9, "+ 2% dano, 3% alcance");
                hotShot.AddSkillPoint(neutron, 10, "Habilita Neutron Avançado");

                hotShot.AddSkillPoint(scatter, 1, "Habilita Scatter Básico");
                hotShot.AddSkillPoint(scatter, 2, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 3, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 4, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 5, "Habilita Scatter Duplo");
                hotShot.AddSkillPoint(scatter, 6, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 7, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 8, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 9, "+ 3% dano, 3% cadência");
                hotShot.AddSkillPoint(scatter, 10, "Habilita Scatter Avançado");

                #endregion

                #region scoult base

                batedor.AddSkillPoint(pilotagem, 1, "Habilita Explorador Básico");
                batedor.AddSkillPoint(pilotagem, 2, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 3, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 4, "+ 3% velocidade, 2% cruzeiro, +1% container");
                batedor.AddSkillPoint(pilotagem, 5, "+ 3% velocidade, 2% cruzeiro, +1% container");
                batedor.AddSkillPoint(pilotagem, 6, "+ 3% velocidade, 2% cruzeiro, +1% container");
                batedor.AddSkillPoint(pilotagem, 7, "+ 3% velocidade, 2% cruzeiro, +1% container");
                batedor.AddSkillPoint(pilotagem, 8, "+Habilita Explorador Intermediário");
                batedor.AddSkillPoint(pilotagem, 9, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 10, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 11, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 12, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 13, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 14, "+ 3% velocidade, 2% cruzeiro, 1% container");
                batedor.AddSkillPoint(pilotagem, 15, "Habilita Explorador Avançado");

                batedor.AddSkillPoint(particulas, 1, "Habilita Partículas Básico");
                batedor.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo");
                batedor.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado");

                batedor.AddSkillPoint(gerenciamento, 1, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 2, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 3, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 4, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 5, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 6, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 7, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 8, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 9, "- 0,2% tempo de ativação do cruzeiro");
                batedor.AddSkillPoint(gerenciamento, 10, "- 0,2% tempo de ativação do cruzeiro");

                batedor.AddSkillPoint(antiradiacao, 1, "-10% custo de ativação");
                batedor.AddSkillPoint(antiradiacao, 2, "-10% custo de ativação");
                batedor.AddSkillPoint(antiradiacao, 3, "-10% custo de ativação");
                batedor.AddSkillPoint(antiradiacao, 4, "-10% custo de ativação");
                batedor.AddSkillPoint(antiradiacao, 5, "-10% custo de ativação");

                batedor.AddSkillPoint(gaus, 1, "Habilita Gauss Básico");
                batedor.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo");
                batedor.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil");
                batedor.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado");

                batedor.AddSkillPoint(neutron, 1, "Habilita Neutron Básico");
                batedor.AddSkillPoint(neutron, 2, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 3, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 4, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 5, "Habilita Neutron Duplo");
                batedor.AddSkillPoint(neutron, 6, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 7, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 8, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 9, "+ 2% dano, 3% alcance");
                batedor.AddSkillPoint(neutron, 10, "Habilita Neutron Avançado");

                batedor.AddSkillPoint(blaster, 1, "Habilita Blaster Básico");
                batedor.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo");
                batedor.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil");
                batedor.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado");

                batedor.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve");
                batedor.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência");
                batedor.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência");
                batedor.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência");
                batedor.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência");

                batedor.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve");
                batedor.AddSkillPoint(mina, 2, "+ 5% dano");
                batedor.AddSkillPoint(mina, 3, "+ 5% dano");
                batedor.AddSkillPoint(mina, 4, "+ 5% dano");
                batedor.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média");

                batedor.AddSkillPoint(otimizacao, 1, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 2, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 3, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 4, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 5, "+ 2% container");

                batedor.AddSkillPoint(rail, 1, "Habilita Rail Básico");
                batedor.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 5, "Habilita Rail Duplo");
                batedor.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance");
                batedor.AddSkillPoint(rail, 10, "Habilita Rail Avançado");

                batedor.AddSkillPoint(escudoSuperior, 1, "+ 5% escudo, 4 regeneração");
                batedor.AddSkillPoint(escudoSuperior, 2, "+ 5% escudo, 4 regeneração");
                batedor.AddSkillPoint(escudoSuperior, 3, "+ 5% escudo, 4 regeneração");
                batedor.AddSkillPoint(escudoSuperior, 4, "+ 5% escudo, 4 regeneração");
                batedor.AddSkillPoint(escudoSuperior, 5, "+ 5% escudo, 4 regeneração");

                batedor.AddSkillPoint(emboscar, 1, "+ 3% alcançe");
                batedor.AddSkillPoint(emboscar, 2, "+ 3% alcançe");
                batedor.AddSkillPoint(emboscar, 3, "+ 3% alcançe");
                batedor.AddSkillPoint(emboscar, 4, "+ 3% alcançe");
                batedor.AddSkillPoint(emboscar, 5, "+ 3% alcançe");

                #endregion

                #region merchant base

                cargueiro.AddSkillPoint(pilotagem, 1, "Habilita Mercador básico");
                cargueiro.AddSkillPoint(pilotagem, 2, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 3, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 4, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 5, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 6, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 7, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 8, "+Habilita Mercador Intermediário");
                cargueiro.AddSkillPoint(pilotagem, 9, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 10, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 11, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 12, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 13, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 14, "+ 3% casco, 2% container, 1% cruzeiro");
                cargueiro.AddSkillPoint(pilotagem, 15, "Habilita Mercador Avançado");

                cargueiro.AddSkillPoint(gerenciamento, 1, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 2, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 3, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 4, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 5, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 6, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 7, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 8, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 9, "- 0,2% tempo de ativação do cruzeiro");
                cargueiro.AddSkillPoint(gerenciamento, 10, "- 0,2% tempo de ativação do cruzeiro");

                cargueiro.AddSkillPoint(particulas, 1, "Habilita Partículas Básico");
                cargueiro.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo");
                cargueiro.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado");

                cargueiro.AddSkillPoint(cofre, 1, "+ 50 cofre");
                cargueiro.AddSkillPoint(cofre, 2, "+ 50 cofre");
                cargueiro.AddSkillPoint(cofre, 3, "+ 50 cofre");
                cargueiro.AddSkillPoint(cofre, 4, "+ 50 cofre");
                cargueiro.AddSkillPoint(cofre, 5, "+ 50 cofre");

                cargueiro.AddSkillPoint(rail, 1, "Habilita Rail Básico");
                cargueiro.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 5, "Habilita Rail Duplo");
                cargueiro.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance");
                cargueiro.AddSkillPoint(rail, 10, "Habilita Rail Avançado");

                cargueiro.AddSkillPoint(blaster, 1, "Habilita Blaster Básico");
                cargueiro.AddSkillPoint(blaster, 2, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 3, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 4, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo");
                cargueiro.AddSkillPoint(blaster, 6, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 7, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 8, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 9, "+ 3% dano, 4% velocidade projétil");
                cargueiro.AddSkillPoint(blaster, 10, "Habilita Blaster Avançado");

                cargueiro.AddSkillPoint(otimizacao, 1, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 2, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 3, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 4, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 5, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 6, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 7, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 8, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 9, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 10, "+ 2% container");

                cargueiro.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve");
                cargueiro.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência");
                cargueiro.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência");
                cargueiro.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência");
                cargueiro.AddSkillPoint(misseis, 5, "+ 5% alcance, 3% cadência");

                cargueiro.AddSkillPoint(foguetes, 1, "Habilita Lançador Categoria Foguete");
                cargueiro.AddSkillPoint(foguetes, 2, "+ 2% dano");
                cargueiro.AddSkillPoint(foguetes, 3, "+ 2% dano");
                cargueiro.AddSkillPoint(foguetes, 4, "+ 2% dano");
                cargueiro.AddSkillPoint(foguetes, 5, "+ 2% dano");

                cargueiro.AddSkillPoint(especialista, 1, "+ 2% dano em todas as minas");
                cargueiro.AddSkillPoint(especialista, 2, "+ 2% dano em todas as minas");
                cargueiro.AddSkillPoint(especialista, 3, "+ 2% dano em todas as minas");
                cargueiro.AddSkillPoint(especialista, 4, "+ 2% dano em todas as minas");
                cargueiro.AddSkillPoint(especialista, 5, "+ 2% dano em todas as minas");

                cargueiro.AddSkillPoint(casco, 1, "+ 5% casco, 4 blindagem");
                cargueiro.AddSkillPoint(casco, 2, "+ 5% casco, 4 blindagem");
                cargueiro.AddSkillPoint(casco, 3, "+ 5% casco, 4 blindagem");
                cargueiro.AddSkillPoint(casco, 4, "+ 5% casco, 4 blindagem");
                cargueiro.AddSkillPoint(casco, 5, "+ 5% casco, 4 blindagem");

                cargueiro.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve");
                cargueiro.AddSkillPoint(mina, 2, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 3, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 4, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média");
                cargueiro.AddSkillPoint(mina, 6, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 7, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 8, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 9, "+ 2% dano");
                cargueiro.AddSkillPoint(mina, 10, "Habilita Lançador Categoria Mina Pesada");

                #endregion

                #region juggernaut base

                bomber.AddSkillPoint(pilotagem, 1, "Habilita Bombardeiro Básico");
                bomber.AddSkillPoint(pilotagem, 2, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 3, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 4, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 5, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 6, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 7, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 8, "+Habilita Bombardeiro Intermediário");
                bomber.AddSkillPoint(pilotagem, 9, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 10, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 11, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 12, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 13, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 14, "+ 3% casco, 2 blindagem, 1% cruzeiro");
                bomber.AddSkillPoint(pilotagem, 15, "Habilita Bombardeiro Avançado");

                bomber.AddSkillPoint(particulas, 1, "Habilita Partículas Básico");
                bomber.AddSkillPoint(particulas, 2, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 3, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 4, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 5, "Habilita Partículas Duplo");
                bomber.AddSkillPoint(particulas, 6, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 7, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 8, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 9, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(particulas, 10, "Habilita Partículas Avançado");

                bomber.AddSkillPoint(misseis, 1, "Habilita Lançador Categoria Míssel Leve");
                bomber.AddSkillPoint(misseis, 2, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 3, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 4, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 5, "Habilita Lançador Categoria Míssel Médio");
                bomber.AddSkillPoint(misseis, 6, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 7, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 8, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 9, "+ 5% alcance, 3% cadência");
                bomber.AddSkillPoint(misseis, 10, "Habilita Lançador Categoria Míssel Pesado");

                bomber.AddSkillPoint(omega, 1, "+ 5% dano, 2 segundos de duração");
                bomber.AddSkillPoint(omega, 2, "+ 5% dano, 2 segundos de duração");
                bomber.AddSkillPoint(omega, 3, "+ 5% dano, 2 segundos de duração");
                bomber.AddSkillPoint(omega, 4, "+ 5% dano, 2 segundos de duração");
                bomber.AddSkillPoint(omega, 5, "+ 5% dano, 2 segundos de duração");

                bomber.AddSkillPoint(foguetes, 1, "Habilita Lançador Categoria Foguete");
                bomber.AddSkillPoint(foguetes, 2, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 3, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 4, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 5, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 6, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 7, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 8, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 9, "+ 2% dano");
                bomber.AddSkillPoint(foguetes, 10, "+ 2% dano");

                bomber.AddSkillPoint(casco, 1, "+ 5% casco, 4 blindagem");
                bomber.AddSkillPoint(casco, 2, "+ 5% casco, 4 blindagem");
                bomber.AddSkillPoint(casco, 3, "+ 5% casco, 4 blindagem");
                bomber.AddSkillPoint(casco, 4, "+ 5% casco, 4 blindagem");
                bomber.AddSkillPoint(casco, 5, "+ 5% casco, 4 blindagem");

                bomber.AddSkillPoint(especdemoli, 1, "+ 2% dano");
                bomber.AddSkillPoint(especdemoli, 2, "+ 2% dano");
                bomber.AddSkillPoint(especdemoli, 3, "+ 2% dano");
                bomber.AddSkillPoint(especdemoli, 4, "+ 2% dano");
                bomber.AddSkillPoint(especdemoli, 5, "+ 2% dano");

                bomber.AddSkillPoint(blaster, 1, "Habilita Blaster Básico");
                bomber.AddSkillPoint(blaster, 2, "+ 3% dano, 3% velocidade projétil");
                bomber.AddSkillPoint(blaster, 3, "+ 3% dano, 3% velocidade projétil");
                bomber.AddSkillPoint(blaster, 4, "+ 3% dano, 3% velocidade projétil");
                bomber.AddSkillPoint(blaster, 5, "Habilita Blaster Duplo");

                bomber.AddSkillPoint(torpedo, 1, "Habilida Lançador Torpedo");
                bomber.AddSkillPoint(torpedo, 2, "+ 5% alcance");
                bomber.AddSkillPoint(torpedo, 3, "+ 5% alcance");
                bomber.AddSkillPoint(torpedo, 4, "+ 5% alcance");
                bomber.AddSkillPoint(torpedo, 5, "+ 5% alcance");

                bomber.AddSkillPoint(mina, 1, "Habilita Lançador Categoria Mina Leve");
                bomber.AddSkillPoint(mina, 2, "+ 2% dano");
                bomber.AddSkillPoint(mina, 3, "+ 2% dano");
                bomber.AddSkillPoint(mina, 4, "+ 2% dano");
                bomber.AddSkillPoint(mina, 5, "Habilita Lançador Categoria Mina Média");
                bomber.AddSkillPoint(mina, 6, "+ 2% dano");
                bomber.AddSkillPoint(mina, 7, "+ 2% dano");
                bomber.AddSkillPoint(mina, 8, "+ 2% dano");
                bomber.AddSkillPoint(mina, 9, "+ 2% dano");
                bomber.AddSkillPoint(mina, 10, "Habilita Lançador Categoria Mina Pesada");

                bomber.AddSkillPoint(gaus, 1, "Habilita Gauss Básico");
                bomber.AddSkillPoint(gaus, 2, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 3, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 4, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 5, "Habilita Gauss Duplo");
                bomber.AddSkillPoint(gaus, 6, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 7, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 8, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 9, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(gaus, 10, "Habilita Gauss Avançado");

                bomber.AddSkillPoint(magnetica, 1, "Habilita Magnético Básico");
                bomber.AddSkillPoint(magnetica, 2, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 3, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 4, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 5, "Habilita Magnético Duplo");
                bomber.AddSkillPoint(magnetica, 6, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 7, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 8, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 9, "+ 3% Cadência, 3% velocidade projétil");
                bomber.AddSkillPoint(magnetica, 10, "Habilita Magnético Avançado");

                bomber.AddSkillPoint(rail, 1, "Habilita Rail Básico");
                bomber.AddSkillPoint(rail, 2, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 3, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 4, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 5, "Habilita Rail Duplo");
                bomber.AddSkillPoint(rail, 6, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 7, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 8, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 9, "+ 3% Dano, 3% alcance");
                bomber.AddSkillPoint(rail, 10, "Habilita Rail Avançado");

                bomber.AddSkillPoint(scatter, 1, "Habilita Scatter Básico");
                bomber.AddSkillPoint(scatter, 2, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 3, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 4, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 5, "Habilita Scatter Duplo");
                bomber.AddSkillPoint(scatter, 6, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 7, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 8, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 9, "+ 3% dano, 3% cadência");
                bomber.AddSkillPoint(scatter, 10, "Habilita Scatter Avançado");

                #endregion

                return new[] { hotShot, batedor, bomber, cargueiro };
            }
            else
            {
                #region Career base

                var hotShot = new Career("HotShot", 69);
                var batedor = new Career("Scout", 69);
                var bomber = new Career("Juggernaut", 69);
                var cargueiro = new Career("Merchant", 69);

                #endregion

                #region skill base

                var pilotagem = new Skill("Pilotage");
                var afterburn = new Skill("Afterburn");
                var canhoneiro = new Skill("Embrasure");
                var escudoSuperior = new Skill("Superior Shield");
                var misseis = new Skill("Demolition: Missiles");
                var Rockets = new Skill("Demolition : Rockets");
                var rail = new Skill("Artillery: Rail");
                var gaus = new Skill("Artillery : Gauss");
                var particulas = new Skill("Artillery : Particle");
                var magnetica = new Skill("Artillery : Magnetic");
                var balistica = new Skill("Artillery : Balistic");
                var plasma = new Skill("Artillery : Plasm");
                var scatter = new Skill("Artillery : Scatter");
                var neutron = new Skill("Artillery : Neutron");
                var emboscar = new Skill("Ambush");
                var blaster = new Skill("Artillery : Blaster");
                var gerenciamento = new Skill("Energy Management");
                var antiradiacao = new Skill("Antiradiation");
                var mina = new Skill("Demolition : Mines");
                var otimizacao = new Skill("Container Optimization");
                var vault = new Skill("Vault");
                var especialista = new Skill("Mine Specialist");
                var hull = new Skill("Hull Armor");
                var omega = new Skill("OmegaStrike");
                var especdemoli = new Skill("Demolition Specialist");
                var torpedo = new Skill("Demolition : Torpedo");

                #endregion

                #region hotshot base

                hotShot.AddSkillPoint(pilotagem, 1, "Enable Basic HotShot");
                hotShot.AddSkillPoint(pilotagem, 2, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 3, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 4, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 5, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 6, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 7, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 8, "Enable Intermediat HotShot");
                hotShot.AddSkillPoint(pilotagem, 9, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 10, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 11, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 12, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 13, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 14, "+ 3% shield, 2% aceleration, 1% speed");
                hotShot.AddSkillPoint(pilotagem, 15, "Enable Advanced HotShot");

                hotShot.AddSkillPoint(gaus, 1, "Enable Basic Gauss");
                hotShot.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 5, "Enable Double Gauss");
                hotShot.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(gaus, 10, "Enable Advanced Gauss");

                hotShot.AddSkillPoint(magnetica, 1, "Enable Basic Magnetic");
                hotShot.AddSkillPoint(magnetica, 2, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 3, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 4, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 5, "Enable Double Magnetic");
                hotShot.AddSkillPoint(magnetica, 6, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 7, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 8, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 9, "+ 3% firing speed, 3% bullet speed");
                hotShot.AddSkillPoint(magnetica, 10, "Enable Advanced Magnetic");

                hotShot.AddSkillPoint(afterburn, 1, "+ 2% speed, 1 duration second");
                hotShot.AddSkillPoint(afterburn, 2, "+ 2% speed, 1 duration second");
                hotShot.AddSkillPoint(afterburn, 3, "+ 2% speed, 1 duration second");
                hotShot.AddSkillPoint(afterburn, 4, "+ 2% speed, 1 duration second");
                hotShot.AddSkillPoint(afterburn, 5, "+ 2% speed, 1 duration second");

                hotShot.AddSkillPoint(rail, 1, "Enable Basic Rail");
                hotShot.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 5, "Enable Double Rail");
                hotShot.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(rail, 10, "Enable Advanced Rail");

                hotShot.AddSkillPoint(particulas, 1, "Enable Basic Particle");
                hotShot.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 5, "Enable Double Particle");
                hotShot.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach");
                hotShot.AddSkillPoint(particulas, 10, "Enable Advanced Particle");

                hotShot.AddSkillPoint(escudoSuperior, 1, "+ 5% shield, 4 regeneration");
                hotShot.AddSkillPoint(escudoSuperior, 2, "+ 5% shield, 4 regeneration");
                hotShot.AddSkillPoint(escudoSuperior, 3, "+ 5% shield, 4 regeneration");
                hotShot.AddSkillPoint(escudoSuperior, 4, "+ 5% shield, 4 regeneration");
                hotShot.AddSkillPoint(escudoSuperior, 5, "+ 5% shield, 4 regeneration");

                hotShot.AddSkillPoint(canhoneiro, 1, "+ 3% damage");
                hotShot.AddSkillPoint(canhoneiro, 2, "+ 3% damage");
                hotShot.AddSkillPoint(canhoneiro, 3, "+ 3% damage");
                hotShot.AddSkillPoint(canhoneiro, 4, "+ 3% damage");
                hotShot.AddSkillPoint(canhoneiro, 5, "+ 3% damage");

                hotShot.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile");
                hotShot.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed");
                hotShot.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed");
                hotShot.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed");
                hotShot.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed");

                hotShot.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket");
                hotShot.AddSkillPoint(Rockets, 2, "+ 2% damage");
                hotShot.AddSkillPoint(Rockets, 3, "+ 2% damage");
                hotShot.AddSkillPoint(Rockets, 4, "+ 2% damage");
                hotShot.AddSkillPoint(Rockets, 5, "+ 2% damage");

                hotShot.AddSkillPoint(balistica, 1, "Enable Basic Ballistic");
                hotShot.AddSkillPoint(balistica, 2, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 3, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 4, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 5, "Enable Double Ballistic");
                hotShot.AddSkillPoint(balistica, 6, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 7, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 8, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 9, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(balistica, 10, "Enable Ballistic Advanced");

                hotShot.AddSkillPoint(plasma, 1, "Enable Basic Plasma");
                hotShot.AddSkillPoint(plasma, 2, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 3, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 4, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 5, "Enable Double Plasma");
                hotShot.AddSkillPoint(plasma, 6, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 7, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 8, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 9, "+ 2% damage, 4% firing speed");
                hotShot.AddSkillPoint(plasma, 10, "Enable Advanced Plasma");

                hotShot.AddSkillPoint(blaster, 1, "Enable Basic Blaster");
                hotShot.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 5, "Enable Double Blaster");
                hotShot.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed");
                hotShot.AddSkillPoint(blaster, 10, "Enable Advanced Blaster");

                hotShot.AddSkillPoint(neutron, 1, "Enable Basic Neutron");
                hotShot.AddSkillPoint(neutron, 2, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 3, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 4, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 5, "Enable Double Neutron");
                hotShot.AddSkillPoint(neutron, 6, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 7, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 8, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 9, "+ 2% damage, 3% reach");
                hotShot.AddSkillPoint(neutron, 10, "Enable Advanced Neutron");

                hotShot.AddSkillPoint(scatter, 1, "Enable Basic Scatter");
                hotShot.AddSkillPoint(scatter, 2, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 3, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 4, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 5, "Enable Double Scatter");
                hotShot.AddSkillPoint(scatter, 6, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 7, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 8, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 9, "+ 3% damage, 3% firing speed");
                hotShot.AddSkillPoint(scatter, 10, "Enable Advanced Scatter");

                #endregion

                #region scoult base

                batedor.AddSkillPoint(pilotagem, 1, "Enable Basic Scoult");
                batedor.AddSkillPoint(pilotagem, 2, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 3, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 4, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 5, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 6, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 7, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Scoult");
                batedor.AddSkillPoint(pilotagem, 9, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 10, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 11, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 12, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 13, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 14, "+ 3% speed +2% cruizer +1% container");
                batedor.AddSkillPoint(pilotagem, 15, "Enable Advanced Scoult");

                batedor.AddSkillPoint(particulas, 1, "Enable Basic Particle");
                batedor.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 5, "Enable Double Particle");
                batedor.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(particulas, 10, "Enable Advanced Particle");

                batedor.AddSkillPoint(gerenciamento, 1, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 2, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 3, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 4, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 5, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 6, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 7, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 8, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 9, "- 0,2% cruizer activation time");
                batedor.AddSkillPoint(gerenciamento, 10, "- 0,2% cruizer activation time");

                batedor.AddSkillPoint(antiradiacao, 1, "-10% activation cost");
                batedor.AddSkillPoint(antiradiacao, 2, "-10% activation cost");
                batedor.AddSkillPoint(antiradiacao, 3, "-10% activation cost");
                batedor.AddSkillPoint(antiradiacao, 4, "-10% activation cost");
                batedor.AddSkillPoint(antiradiacao, 5, "-10% activation cost");

                batedor.AddSkillPoint(gaus, 1, "Enable Basic Gauss");
                batedor.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 5, "Enable Double Gauss");
                batedor.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed");
                batedor.AddSkillPoint(gaus, 10, "Enable Advanced Gauss");

                batedor.AddSkillPoint(neutron, 1, "Enable Basic Neutron");
                batedor.AddSkillPoint(neutron, 2, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 3, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 4, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 5, "Enable Double Neutron");
                batedor.AddSkillPoint(neutron, 6, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 7, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 8, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 9, "+ 2% damage, 3% reach");
                batedor.AddSkillPoint(neutron, 10, "Enable Advanced Neutron");

                batedor.AddSkillPoint(blaster, 1, "Enable Basic Blaster");
                batedor.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 5, "Enable Double Blaster");
                batedor.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed");
                batedor.AddSkillPoint(blaster, 10, "Enable Advanced Blaster");

                batedor.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile");
                batedor.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed");
                batedor.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed");
                batedor.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed");
                batedor.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed");

                batedor.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine");
                batedor.AddSkillPoint(mina, 2, "+ 5% damage");
                batedor.AddSkillPoint(mina, 3, "+ 5% damage");
                batedor.AddSkillPoint(mina, 4, "+ 5% damage");
                batedor.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine");

                batedor.AddSkillPoint(otimizacao, 1, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 2, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 3, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 4, "+ 2% container");
                batedor.AddSkillPoint(otimizacao, 5, "+ 2% container");

                batedor.AddSkillPoint(rail, 1, "Enable Basic Rail");
                batedor.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 5, "Enable Double Rail");
                batedor.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach");
                batedor.AddSkillPoint(rail, 10, "Enable Advanced Rail");

                batedor.AddSkillPoint(escudoSuperior, 1, "+ 5% shield, 4 regeneration");
                batedor.AddSkillPoint(escudoSuperior, 2, "+ 5% shield, 4 regeneration");
                batedor.AddSkillPoint(escudoSuperior, 3, "+ 5% shield, 4 regeneration");
                batedor.AddSkillPoint(escudoSuperior, 4, "+ 5% shield, 4 regeneration");
                batedor.AddSkillPoint(escudoSuperior, 5, "+ 5% shield, 4 regeneration");

                batedor.AddSkillPoint(emboscar, 1, "+ 3% reach");
                batedor.AddSkillPoint(emboscar, 2, "+ 3% reach");
                batedor.AddSkillPoint(emboscar, 3, "+ 3% reach");
                batedor.AddSkillPoint(emboscar, 4, "+ 3% reach");
                batedor.AddSkillPoint(emboscar, 5, "+ 3% reach");

                #endregion

                #region merchant base

                cargueiro.AddSkillPoint(pilotagem, 1, "Enable Basic Merchant");
                cargueiro.AddSkillPoint(pilotagem, 2, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 3, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 4, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 5, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 6, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 7, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Merchant");
                cargueiro.AddSkillPoint(pilotagem, 9, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 10, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 11, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 12, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 13, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 14, "+ 3% hull, 2% container, 1% cruizer");
                cargueiro.AddSkillPoint(pilotagem, 15, "Enable Advanced Merchant");

                cargueiro.AddSkillPoint(gerenciamento, 1, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 2, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 3, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 4, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 5, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 6, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 7, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 8, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 9, "- 0,2% cruizer activation time");
                cargueiro.AddSkillPoint(gerenciamento, 10, "- 0,2% cruizer activation time");

                cargueiro.AddSkillPoint(particulas, 1, "Enable Basic Particle");
                cargueiro.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 5, "Enable Double Particle");
                cargueiro.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(particulas, 10, "Enable Advanced Particle");

                cargueiro.AddSkillPoint(vault, 1, "+ 50 vault");
                cargueiro.AddSkillPoint(vault, 2, "+ 50 vault");
                cargueiro.AddSkillPoint(vault, 3, "+ 50 vault");
                cargueiro.AddSkillPoint(vault, 4, "+ 50 vault");
                cargueiro.AddSkillPoint(vault, 5, "+ 50 vault");

                cargueiro.AddSkillPoint(rail, 1, "Enable Basic Rail");
                cargueiro.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 5, "Enable Double Rail");
                cargueiro.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach");
                cargueiro.AddSkillPoint(rail, 10, "Enable Advanced Rail");

                cargueiro.AddSkillPoint(blaster, 1, "Enable Basic Blaster");
                cargueiro.AddSkillPoint(blaster, 2, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 3, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 4, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 5, "Enable Double Blaster");
                cargueiro.AddSkillPoint(blaster, 6, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 7, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 8, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 9, "+ 3% damage, 4% bullet speed");
                cargueiro.AddSkillPoint(blaster, 10, "Enable Advanced Blaster");

                cargueiro.AddSkillPoint(otimizacao, 1, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 2, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 3, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 4, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 5, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 6, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 7, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 8, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 9, "+ 2% container");
                cargueiro.AddSkillPoint(otimizacao, 10, "+ 2% container");

                cargueiro.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile");
                cargueiro.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed");
                cargueiro.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed");
                cargueiro.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed");
                cargueiro.AddSkillPoint(misseis, 5, "+ 5% reach, 3% firing speed");

                cargueiro.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket");
                cargueiro.AddSkillPoint(Rockets, 2, "+ 2% damage");
                cargueiro.AddSkillPoint(Rockets, 3, "+ 2% damage");
                cargueiro.AddSkillPoint(Rockets, 4, "+ 2% damage");
                cargueiro.AddSkillPoint(Rockets, 5, "+ 2% damage");

                cargueiro.AddSkillPoint(especialista, 1, "+ 2% damage in all mines");
                cargueiro.AddSkillPoint(especialista, 2, "+ 2% damage in all mines");
                cargueiro.AddSkillPoint(especialista, 3, "+ 2% damage in all mines");
                cargueiro.AddSkillPoint(especialista, 4, "+ 2% damage in all mines");
                cargueiro.AddSkillPoint(especialista, 5, "+ 2% damage in all mines");

                cargueiro.AddSkillPoint(hull, 1, "+ 5% hull, 4 armor");
                cargueiro.AddSkillPoint(hull, 2, "+ 5% hull, 4 armor");
                cargueiro.AddSkillPoint(hull, 3, "+ 5% hull, 4 armor");
                cargueiro.AddSkillPoint(hull, 4, "+ 5% hull, 4 armor");
                cargueiro.AddSkillPoint(hull, 5, "+ 5% hull, 4 armor");

                cargueiro.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine");
                cargueiro.AddSkillPoint(mina, 2, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 3, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 4, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine");
                cargueiro.AddSkillPoint(mina, 6, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 7, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 8, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 9, "+ 2% damage");
                cargueiro.AddSkillPoint(mina, 10, "Enable Launcher Category Hard Mine");

                #endregion

                #region juggernaut base

                bomber.AddSkillPoint(pilotagem, 1, "Enable Basic Bomber");
                bomber.AddSkillPoint(pilotagem, 2, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 3, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 4, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 5, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 6, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 7, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 8, "+Enable Intermediat Bomber");
                bomber.AddSkillPoint(pilotagem, 9, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 10, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 11, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 12, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 13, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 14, "+ 3% hull, 2 armor, 1% cruizer");
                bomber.AddSkillPoint(pilotagem, 15, "Enable Advanced Bomber");

                bomber.AddSkillPoint(particulas, 1, "Enable Basic Particle");
                bomber.AddSkillPoint(particulas, 2, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 3, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 4, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 5, "Enable Double Particle");
                bomber.AddSkillPoint(particulas, 6, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 7, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 8, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 9, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(particulas, 10, "Enable Advanced Particle");

                bomber.AddSkillPoint(misseis, 1, "Enable Launcher Category Light Missile");
                bomber.AddSkillPoint(misseis, 2, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 3, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 4, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 5, "Enable Launcher Category Medium Missile");
                bomber.AddSkillPoint(misseis, 6, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 7, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 8, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 9, "+ 5% reach, 3% firing speed");
                bomber.AddSkillPoint(misseis, 10, "Enable Launcher Category Hard Missile");

                bomber.AddSkillPoint(omega, 1, "+ 5% damage, 2 duration seconds");
                bomber.AddSkillPoint(omega, 2, "+ 5% damage, 2 duration seconds");
                bomber.AddSkillPoint(omega, 3, "+ 5% damage, 2 duration seconds");
                bomber.AddSkillPoint(omega, 4, "+ 5% damage, 2 duration seconds");
                bomber.AddSkillPoint(omega, 5, "+ 5% damage, 2 duration seconds");

                bomber.AddSkillPoint(Rockets, 1, "Enable Launcher Category Rocket");
                bomber.AddSkillPoint(Rockets, 2, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 3, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 4, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 5, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 6, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 7, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 8, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 9, "+ 2% damage");
                bomber.AddSkillPoint(Rockets, 10, "+ 2% damage");

                bomber.AddSkillPoint(hull, 1, "+ 5% hull, 4 armor");
                bomber.AddSkillPoint(hull, 2, "+ 5% hull, 4 armor");
                bomber.AddSkillPoint(hull, 3, "+ 5% hull, 4 armor");
                bomber.AddSkillPoint(hull, 4, "+ 5% hull, 4 armor");
                bomber.AddSkillPoint(hull, 5, "+ 5% hull, 4 armor");

                bomber.AddSkillPoint(especdemoli, 1, "+ 2% damage");
                bomber.AddSkillPoint(especdemoli, 2, "+ 2% damage");
                bomber.AddSkillPoint(especdemoli, 3, "+ 2% damage");
                bomber.AddSkillPoint(especdemoli, 4, "+ 2% damage");
                bomber.AddSkillPoint(especdemoli, 5, "+ 2% damage");

                bomber.AddSkillPoint(blaster, 1, "Enable Basic Blaster");
                bomber.AddSkillPoint(blaster, 2, "+ 3% damage, 3% bullet speed");
                bomber.AddSkillPoint(blaster, 3, "+ 3% damage, 3% bullet speed");
                bomber.AddSkillPoint(blaster, 4, "+ 3% damage, 3% bullet speed");
                bomber.AddSkillPoint(blaster, 5, "Enable Double Blaster");

                bomber.AddSkillPoint(torpedo, 1, "Enable Launcher Torpedo");
                bomber.AddSkillPoint(torpedo, 2, "+ 5% reach");
                bomber.AddSkillPoint(torpedo, 3, "+ 5% reach");
                bomber.AddSkillPoint(torpedo, 4, "+ 5% reach");
                bomber.AddSkillPoint(torpedo, 5, "+ 5% reach");

                bomber.AddSkillPoint(mina, 1, "Enable Launcher Category Light Mine");
                bomber.AddSkillPoint(mina, 2, "+ 2% damage");
                bomber.AddSkillPoint(mina, 3, "+ 2% damage");
                bomber.AddSkillPoint(mina, 4, "+ 2% damage");
                bomber.AddSkillPoint(mina, 5, "Enable Launcher Category Medium Mine");
                bomber.AddSkillPoint(mina, 6, "+ 2% damage");
                bomber.AddSkillPoint(mina, 7, "+ 2% damage");
                bomber.AddSkillPoint(mina, 8, "+ 2% damage");
                bomber.AddSkillPoint(mina, 9, "+ 2% damage");
                bomber.AddSkillPoint(mina, 10, "Enable Launcher Category Hard Mine");

                bomber.AddSkillPoint(gaus, 1, "Enable Basic Gauss");
                bomber.AddSkillPoint(gaus, 2, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 3, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 4, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 5, "Enable Double Gauss");
                bomber.AddSkillPoint(gaus, 6, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 7, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 8, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 9, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(gaus, 10, "Enable Advanced Gauss");

                bomber.AddSkillPoint(magnetica, 1, "Enable Magnetic Basic");
                bomber.AddSkillPoint(magnetica, 2, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 3, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 4, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 5, "Enable Double Magnetic");
                bomber.AddSkillPoint(magnetica, 6, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 7, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 8, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 9, "+ 3% firing speed, 3% bullet speed");
                bomber.AddSkillPoint(magnetica, 10, "Enable Advanced Magnetic");

                bomber.AddSkillPoint(rail, 1, "Enable Basic Rail");
                bomber.AddSkillPoint(rail, 2, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 3, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 4, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 5, "Enable Double Rail");
                bomber.AddSkillPoint(rail, 6, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 7, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 8, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 9, "+ 3% damage, 3% reach");
                bomber.AddSkillPoint(rail, 10, "Enable Advanced Rail");

                bomber.AddSkillPoint(scatter, 1, "Enable Basic Scatter");
                bomber.AddSkillPoint(scatter, 2, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 3, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 4, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 5, "Enable Double Scatter");
                bomber.AddSkillPoint(scatter, 6, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 7, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 8, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 9, "+ 3% damage, 3% firing speed");
                bomber.AddSkillPoint(scatter, 10, "Enable Advanced Scatter");

                #endregion

                return new[] { hotShot, batedor, bomber, cargueiro };
            }
            
            //return null;//new[] { hotShot, batedor, bomber, cargueiro };
        }
    }
}